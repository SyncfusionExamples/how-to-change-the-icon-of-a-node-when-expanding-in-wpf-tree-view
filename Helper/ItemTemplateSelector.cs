using Syncfusion.UI.Xaml.TreeView.Engine;
using System.Windows;
using System.Windows.Controls;

namespace SfTreeViewDemo
{
    class ItemTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var treeviewNode = item as TreeViewNode;
            if (treeviewNode == null)
                return null;

            //Check the conditionn for Node expande or Collapsed 
            if (treeviewNode.IsExpanded)
            {
                DataTemplate dataTemplate = ((FrameworkElement)container).FindResource("headerTemplate") as DataTemplate;
                //while Node expanded state added the FolderOpen Icon in below mentioed temaplate
                return dataTemplate;
            }
            else
            {
                DataTemplate dataTemplate = ((FrameworkElement)container).FindResource("headerTemplate1") as DataTemplate;
                //while node collapsed state added the FolderClose Icon in below mentioed temaplate
                return dataTemplate;
            }
        }
    }
}
