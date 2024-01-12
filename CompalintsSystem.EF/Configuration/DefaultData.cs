﻿using CompalintsSystem.Core.Helpers.Constants;
using CompalintsSystem.Core.Models;
using CompalintsSystem.EF.DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CompalintsSystem.EF.Configuration
{
    public class DefaultData
    {
        public static async Task SeedCompalintAndSolustionAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<AppCompalintsContextDB>();

                if (!dbContext.UploadsComplaintes.Any())
                {
                    var uploadsCompalints = new UploadsComplainte
                    {

                        TitleComplaint = "نقص العلاجات والأدوات والتوعية الزراعية",
                        DescComplaint = "\r\nالموضوع: شكوى بشأن نقص العلاجات والأدوات والتوعية الزراعية\r\n\r\n\r\nأتمنى أن تصلكم هذه الرسالة في أتم الصحة والعافية. أنا سعيد علي احمد ، طالب يمني مخلص لهذا الوطن ومهتم بتطوير القطاع الزراعي في بلادنا الجميلة.\r\n\r\nأود أن أبدي استياءي العميق وشكواي بخصوص الوضع الحالي للزراعة في اليمن، وتحديدًا فيما يتعلق بنقص العلاجات الزراعية والأدوات اللازمة لتنمية القطاع الزراعي بشكل فعال، بالإضافة إلى نقص التوعية الزراعية الملائمة.\r\n\r\nفي ظل الظروف الصعبة التي يواجهها القطاع الزراعي في اليمن، فإن نقص العلاجات والأدوات الزراعية يؤثر سلبًا على إنتاجية الطالبين وجودة المحاصيل. نحن بحاجة ماسة إلى توفير العلاجات المناسبة لمكافحة الآفات والأمراض التي تهدد محاصيلنا وتقوم بتدميرها. كما أننا بحاجة إلى الأدوات والمعدات الزراعية الحديثة التي تسهم في زيادة الإنتاجية وتحسين جودة المنتجات.\r\n\r\nبالإضافة إلى ذلك، يعاني القطاع الزراعي من نقص التوعية الزراعية الملائمة. نحن بحاجة إلى برامج وحملات تثقيفية تستهدف الطالبين وتزودهم بالمعلومات اللازمة حول أفضل الممارسات الزراعية، وكذلك توفر التوجيه والاستشارات الفنية لمواجهة التحديات الزراعية المتغيرة.\r\n\r\nأنا مدرك للتحديات الكبيرة التي تواجهها البلاد حاليًا، ولكن أعتقد أن تطوير القطاع الزراعي يشكل جزءًا أساسيًا في بناء مستقبل أفضل لليمن. لذا، أناشدكم بأن تولوا هذه الشكوى بجدية وتعملوا على تحسين الوضع الحالي من خلال توفير العلاجات الزراعية اللازمة، وتوفير الأدوات والمعدات الحديثة، وتعزيز التوعية الزراعية.\r\n\r\nأنا واثق أن بإمكانكم أن تتخذوا الإجراءات اللازمة لتحسين الوضع الزراعي في اليمن وتقديم الدعم اللازم للطالبين. سأكون ممتنًا لو تم تنظيم ورش عمل ودورات تدريبية للطالبين لتعزيز مهاراتهم وزيادة وعيهم بأحدث التقنيات الزراعية.\r\n\r\nأنا على استعداد لتقديم أي مساهمة أو مشاركة في هذا الجهد، وأتطلع إلى رؤية تحسن ملموس في القطاع الزراعي في بلادنا.\r\n\r\nأشكركم مقدمًا على اهتمامكم وتعاونكم، وأنا في انتظار استجابتكم في أقرب وقت ممكن.\r\n\r\nمع خالص التحية،",
                        CollegesId = 2,
                        DepartmentsId = 1,
                        SubDepartmentsId = 2,
                        FileName = "سعيد علي احمد",
                        UserId = "000243124222",
                        UploadDate = DateTime.Now,
                        TypeComplaintId = 1,
                        SocietyId = 1,
                        StatusCompalintId = 2,
                        StagesComplaintId = 1,
                        UserRoleName = UserRolesArbic.Beneficiarie
                    };
                    var compalintsSolution = new Compalints_Solution
                    {
                        ContentSolution = "اخي المواطن سعيد علي احمد \r\nتحية طيبة،\r\n\r\nأود أن أعبر لك عن تقديري العميق لثقتكم بنا ممثلين عزلة القفاعة مخلاف، وعلى تقديمكم للشكوى المتعلقة بنقص العلاجات والأدوات والتوعية الزراعية.\r\n\r\nنحن ندرك تمامًا أهمية قطاع الزراعة في تنمية البلاد وتحسين معيشة الطالبين. وبناءً على شكواكم، قمنا بإجراء التحقيقات والدراسات اللازمة لفهم الوضع الحالي وتحديد الخطوات المناسبة للتحسين.\r\n\r\nنود أن نؤكد لكم أننا نعمل جاهدين على حل مشكلة نقص العلاجات الزراعية والأدوات المطلوبة لدعم الطالبين. قد تواجهنا بعض التحديات والعقبات في توفير الموارد اللازمة في ظل الظروف الصعبة التي تمر بها البلاد، ولكن نحن نعمل بكل الإمكانات المتاحة لتوفير العلاجات والأدوات التي تعزز الإنتاجية وتحسن جودة المحاصيل.\r\n\r\nبالإضافة إلى ذلك، سنعمل على تعزيز التوعية الزراعية من خلال تنظيم برامج وحملات تثقيفية تستهدف الطالبين. سنقوم بتوفير المعلومات المهمة حول أفضل الممارسات الزراعية وتقديم الدعم الفني والاستشارات اللازمة لمساعدتكم في التعامل مع التحديات الزراعية المختلفة.\r\n\r\nنحن نعتز بتواصلكم ونقدر اهتمامكم بتطوير القطاع الزراعي في اليمن. نحن ملتزمون بتحسين الوضع الزراعي وتقديم الدعم اللازم للطالبين في جميع أنحاء البلاد.\r\n\r\nإذا كان لديكم أي استفسارات إضافية أو توجيهات خاصة، فلا تترددوا في التواصل معنا. نحن هنا لخدمتكم والعمل سويًا من أجل تحقيق التقدم في قطاع الزراعة.\r\n\r\nشاكرين لكم صبركم وتفهمكم، ونأمل في أن يكون لديكم تجربة زراعية ناجحة ومثمرةمع خالص التحية،\r\n\r\nعبدالجليل سرحان الدعيس\r\nادارة شئون الطلاب\r\nعزلة القفاعة \r\nمحافظة تــــعــــــز",
                        DateSolution = DateTime.Now,
                        IsAccept = true,
                        UserId = "e70aa106-c6d6-4037-bb94-eb241dd1ef60",
                        SolutionProvName = "عبدالجليل سرحان غالب الدعيس",
                        UploadsComplainteId = 1,
                        SolutionProvIdentity = "001024312444",

                        Role = UserRolesArbic.AdminSubDepartments // "ادارة شئون الطلاب",


                    };

                    // await dbContext.Database.ExecuteSqlRawAsync("DBCC CHECKIDENT ('UploadsComplainte', RESEED, 0)");//'UploadsComplainte' إلى القيمة '0' وتوليد القيمة '1' في المرة القادمة عند إدخال سجل جديد.
                    await dbContext.UploadsComplaintes.AddAsync(uploadsCompalints);
                    await dbContext.SaveChangesAsync();
                    await dbContext.Compalints_Solutions.AddAsync(compalintsSolution);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}