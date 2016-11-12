using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CEA_CR.PlatForm.ViewModels;
using Microsoft.Practices.Prism.Commands;

namespace CEA_CR.PlatForm.Views
{
    /// <summary>
    /// Course.xaml 的交互逻辑
    /// </summary>
    public partial class CompusPageView : Window
    {
        public CompusPageView()
        {
            InitializeComponent();
            this.introduction.Text = @"　加州，库比蒂诺——苹果公司或许是这个星球上唯一一个敢把自己和毕加索(Picasso)相提并论的技术公司了。

　公司的内部培训计划被称为“苹果大学”，在其中一堂课上，导师将11张构成毕加索《公牛》(The Bull)的版画与苹果公司打造智能手机及其他产品的方式联系起来。他的意思是：苹果设计师像毕加索一样追求简洁，去掉繁琐的细节，创造出伟大的艺术品。
　
　史蒂夫·P·乔布斯(Steven P. Jobs)创立苹果大学的目的是向员工灌输苹果的商业文化，并传授公司的历史，特别是公司的发展和技术经济的变革。课程并非必修，只作为推荐课程，但是吸引新雇员来听课从来就不成问题。

　许多公司也有类似的内部培训，有时会被视作“灌输”，而苹果公司培训的主题则是思考与技术世界的魅力。";
        }
    }

    public class CompusPageViewModel
    {
        #region 退出事件
        private ICommand closeCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (closeCommand == null)
                {
                    closeCommand = new DelegateCommand<Window>(w =>
                    {
                        w.Close();
                    });
                }
                return closeCommand;
            }
        }
        #endregion
    }
}
