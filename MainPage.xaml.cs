using System.Collections.Generic;
using Xamarin.Forms;
using UthaiThaniTourismApp.Views;
using System.Diagnostics;
using System.Threading;

namespace UthaiThaniTourismApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // ข้อมูลสถานที่ท่องเที่ยว
            var tourismPlaces = new List<TourismPlace>
            {
                new TourismPlace
                {
                    Name = "เขาสะแกกรัง",
                    Description = "เขาสะแกกรังเป็นยอดเขาสูงที่ตั้งอยู่ใจกลางเมืองอุทัยธานี นักท่องเที่ยวสามารถเดินขึ้นไปยังจุดชมวิวเพื่อสัมผัสบรรยากาศธรรมชาติและมองเห็นทิวทัศน์ของเมืองอุทัยธานีได้แบบพาโนรามา นอกจากนี้ยังมีวัดและศาสนสถานที่สำคัญบนยอดเขาอีกด้วย",
                    ImageSource = "t1.jpg"
                },
                new TourismPlace
                {
                    Name = "วัดอุโปสถาราม",
                    Description = "วัดอุโปสถารามเป็นวัดเก่าแก่ที่มีสถาปัตยกรรมสวยงามและเปี่ยมไปด้วยประวัติศาสตร์ของจังหวัดอุทัยธานี ภายในวัดมีพระพุทธรูปสำคัญและภาพจิตรกรรมฝาผนังที่เล่าเรื่องราวทางศาสนา ซึ่งเหมาะสำหรับผู้ที่สนใจวัฒนธรรมและประวัติศาสตร์",
                    ImageSource = "t2.jpg"
                },
                new TourismPlace
                {
                    Name = "หุบป่าตาด",
                    Description = "หุบป่าตาดเป็นสถานที่ท่องเที่ยวเชิงธรรมชาติที่มีความโดดเด่นด้วยป่าดึกดำบรรพ์และต้นตาดขนาดใหญ่ อากาศเย็นสบายตลอดปี เหมาะสำหรับการเดินป่าและสัมผัสธรรมชาติอย่างใกล้ชิด นอกจากนี้ยังมีน้ำตกเล็กๆ ที่ไหลผ่านบริเวณป่าอีกด้วย",
                    ImageSource = "t3.jpg"
                },
                new TourismPlace
                {
                    Name = "น้ำตกผาร่มเย็น",
                    Description = "น้ำตกผาร่มเย็นเป็นน้ำตกขนาดกลางที่ตั้งอยู่ท่ามกลางธรรมชาติอันร่มรื่น มีน้ำไหลลดหลั่นลงมาหลายชั้น นักท่องเที่ยวสามารถแช่น้ำเย็นๆ และพักผ่อนใต้ร่มไม้ใหญ่ที่รายล้อมบริเวณน้ำตก สถานที่แห่งนี้เหมาะสำหรับการพักผ่อนหย่อนใจในวันสบายๆ",
                    ImageSource = "t4.jpg"
                },
                new TourismPlace
                {
                    Name = "วัดถ้ำเขาวง",
                    Description = "วัดถ้ำเขาวงเป็นวัดที่ตั้งอยู่ในถ้ำธรรมชาติ มีความเงียบสงบและเหมาะสำหรับการปฏิบัติธรรม ภายในถ้ำมีพระพุทธรูปและโบราณสถานที่แสดงถึงความสำคัญทางศาสนา นักท่องเที่ยวสามารถเดินสำรวจถ้ำและสัมผัสความงามของธรรมชาติรอบๆ ได้",
                    ImageSource = "t5.jpg"
                },
                new TourismPlace
                {
                    Name = "ต้นไม้ยักษ์",
                    Description = "ต้นไม้ยักษ์เป็นหนึ่งในแลนด์มาร์กของจังหวัดอุทัยธานี ตั้งอยู่ในสวนสาธารณะใจกลางเมือง ต้นไม้มีขนาดใหญ่โตและอายุยาวนานหลายร้อยปี เป็นสถานที่พักผ่อนหย่อนใจของชาวเมืองและนักท่องเที่ยว พร้อมกับมีมุมถ่ายรูปสวยๆ มากมาย",
                    ImageSource = "t6.jpg"
                }
            };

            TourismCollection.ItemsSource = tourismPlaces;

        }

        private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                var selectedPlace = (TourismPlace)e.CurrentSelection[0];
                await Navigation.PushAsync(new DetailPage(selectedPlace));

                // ล้างค่า Selection หลังเลือก
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }



    public class TourismPlace
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}