#pragma checksum "C:\Users\A\source\repos\VigiStore\ServiceHost\Areas\Administration\Pages\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580cc8a8aa05b191b39c4945e747af9d59590caa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Pages_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Administration/Pages/Shared/_AdminLayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580cc8a8aa05b191b39c4945e747af9d59590caa", @"/Areas/Administration/Pages/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Pages_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminthem/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-100 dark:bg-gray-800 rounded-2xl h-screen overflow-hidden relative font-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"fa\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580cc8a8aa05b191b39c4945e747af9d59590caa4725", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"./style.css\">\r\n    <title>امین پنل</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "580cc8a8aa05b191b39c4945e747af9d59590caa5251", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580cc8a8aa05b191b39c4945e747af9d59590caa7137", async() => {
                WriteLiteral(@"
    <div class=""flex items-start justify-between"">
        <!-- Nav Bar -->
        <div class=""h-screen hidden lg:block my-4 mr-4 shadow-lg relative w-80"">
            <div class=""bg-white h-full rounded-2xl dark:bg-gray-700"">
                <div class=""flex items-center justify-center pt-6"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""35""
                         height=""35"">
                        <image width=""35"" height=""35""
                               xlink:href=""data:img/png;base64,iVBORw0KGgoAAAANSUhEUgAAACMAAAAjCAYAAAAe2bNZAAAAP0lEQVRYhe3OMQEAIADDsIF/z0NBuXc0CnLaNiPuSiRmPswQM8QMMUPMEDPEDDFDzBAzxAwxQ8wQM8QM2ckkeX+LBELpdJssAAAAAElFTkSuQmCC"" />
                        <image x=""2"" width=""28"" height=""25""
                               xlink:href=""data:img/png;base64,iVBORw0KGgoAAAANSUhEUgAAABwAAAAZCAYAAAAiwE4nAAAEYUlEQVRIia1WTYgcRRT+vldV3TOz2exffsghJBcNGhU1BxOQJMRDAgoi/ixBBCFeRC/i0asiePDmSSVBoiARDQgBEU8JBA+Cp0gkNyWERFeT7M5");
                WriteLiteral(@"Md1fVk+qZXXtmZyVR38w3VFf36/f31XvDHVOEAmD6EFgpFb1S6/UkUQWsEbjM7l8pqhMKHNg8lfemJR71PjzSXwnfbaSbRDa+NVmMkTlY+Wi59Bd81FdC1L3d2/3LZVG1b1b6AQUz/6R/xwZTZGK4LQrPdQt/IoRoVu+1DU9G4eGVMu6JwoN3ZdAQdYqTgSZEaJT8pKjC/rEXXHfExX7AS+m6Ao4L6xpNxIjBZCi3AiuoaygNWCeLhY9Hxx10wLdBMbdcxsPpuh9xLBLbBl6vx7oIk6GpXFKtYO0QTlwZ9M0U6bjkglOR+lRU5OmWjzoXySc34s3EGmaWcAbwAAKAKuKB0sdH1zkHXG1ZnK+IF5r7fcWL2MDihqSZyohMgBAUGrU36RlHfC0GW/sBR5r7RdTHVXjPJB0znXHoLTH4cq24uROQRAjxNyh+j8AuALcBLCVMCd4S4t6uxz4AywTaAKzWJedVo7gwXoV08GcVKAlq02BNMiEqBQufokS3CjqbWdods3kkobMtuxxV29eXCq4UsSxLP1tEPFECrxnL+U1BH46KkexwOuP7/YBFqPab7WV1FQGq1oGm4xGsoW7uOJ+uo8KQ1LKKEao3WkbOM8RPfeEvFcTLcx17gapXRgxOCeY9ea4I+thG9bwbcc7Eubb7zJT+9a3z7mYrNxhhd4fAJsGW3PDHySfn32FT213elpk98wCaqA0OjHJXJvzhfzXaspe2O9m+AGCBAxg3LJYCNw3xuSETy+7TAeP+k5Q+bjWZOZgDZ1W1WxOx0zigOvwhsROCA1XEoaDYMeDL2jOpo9hhy615oGtq6DciXCVfPpObk7YKZ+oxOG3GYyAMFe2ch6ZyXCsjez6Sqb8aY3irF6/d6vo+/85MDSNAOzc7hbRpP0RFiICzggy86bvlUk39WcsRzDhiS44HrUBrGBRGUFhB4QzLjvBIynUKM/UMN0RLgMzgSyErEZZClCTKtJ5pua+2CLEggIxXOuXHA8/7mBox4AOyEJH5iCwE/RW");
                WriteLiteral(@"qF5tjJjlthqEa4ExUtTGqiwqnCpfWXR+O0cjuelqkVDSRWXVFxLOTyGKIs8Cwcwy7UfKYQwjwjTO4Ma7ng7bgzDOD5xtDNqoigvsLj/vXVZboWeBDbaRDhkxZHbQasZQJPx7XVVX0gi5SmL4DpQQjRKAcjxPmngPeoeKnUXqN1iM5w4D3Wo4/j+v3Q9wn1jwksY4MCHUBubnn49PrjBGnLPAuGs6tRTaevqh/5ORz7cz8MrLvg/Uii5h1XMNCSxbTFFj1mUCREW93CFntSONIjB1HB8C04d7M8Hs03tfJ3RXTsYP/o4kwnnyj73W3AH9a4ouMeNUAp5sH+U4kBR4VNyxw2givUmS7QltV0Oovk70DD93TSqEAAAAASUVORK5CYII="" />
                        <path data-name=""Color Fill 1""
                              d=""m6.676 25.868.844.094c-.031 1.457-.29 3.909.281 4.878a3.406 3.406 0 0 0 1.876-.281v-1.595h.75a2.834 2.834 0 0 0 .373 1.876 3.665 3.665 0 0 0 2.251-.375v-1.5h.749l-.188 2.157c-1.1.815-2.539.479-3.752.094-.488.618-1.615.521-2.439.281-.075 2.23-3.357 3.574-4.69 1.595a6.12 6.12 0 0 1-.37-3.192h.75a10.822 10.822 0 0 0 .189 2.628l.657.563c3.974.109 2.825-3.583 2.719-7.223Zm23.731 0h.75v5.816h-.75v-5.816ZM9.583 26.994l.938.094-.094.75-.937-.094Zm8.536 1.032h.844v.75h-.844v-.75Zm-1.97 1.874h.751a10.828 10.828 0 0 0 .188 2.626l.657.563c3.013.1");
                WriteLiteral(@"24 2.839-1.259 2.72-4.127l.844.094a3.149 3.149 0 0 0 .281 1.782 3.67 3.67 0 0 0 1.97-.281v-1.593h.75a2.834 2.834 0 0 0 .375 1.876H25.9l.281-.281a2.837 2.837 0 0 1 .563-2.064c1.983-.652 2.913.634 2.345 2.533-1.426 1.087-1.253.271-2.533.188l-.657.469c-.927.321-1.633-.306-2.157-.469-.5.626-1.7.524-2.533.281-.075 2.23-3.357 3.574-4.69 1.595a6.122 6.122 0 0 1-.37-3.192Zm11.256-.844-.469.469a1.655 1.655 0 0 0 .375 1.313h.094a1.394 1.394 0 0 0 1.126-.375v-.092l-.094-.844c-.209-.427-.382-.481-1.032-.469Zm-2.626 4.5h-.844l.094-.844.75.094v.75Zm-13.226-.75h.847v.75h-.847v-.746Zm1.219 0h.844v.75h-.843v-.746Zm9.943 0h.75v.75h-.75v-.746ZM12.21 34.029h.75v.75h-.75v-.75Z""
                              style=""fill:#e8125e;fill-rule:evenodd"" />
                    </svg>

                </div>
                <nav class=""mt-6"">
                    <div>
                        <a class=""w-full font-thin text-blue-500 flex items-center p-4 my-2 transition-colors duration-200 justify-start bg-gradient-to-l from-white to");
                WriteLiteral(@"-blue-100 border-l-4 border-blue-500 dark:from-gray-700 dark:to-gray-800 border-l-4 border-blue-500""
                           href=""./index.html"">
                            <span class=""text-left"">
                                <svg width=""20"" height=""20"" fill=""currentColor"" viewBox=""0 0 2048 1792""
                                     xmlns=""http://www.w3.org/2000/svg"">
                                    <path d=""M1070 1178l306-564h-654l-306 564h654zm722-282q0 182-71 348t-191 286-286 191-348 71-348-71-286-191-191-286-71-348 71-348 191-286 286-191 348-71 348 71 286 191 191 286 71 348z"">
                                    </path>
                                </svg>
                            </span>
                            <span class=""mx-4  font-normal text-lg"">
                                داشبورد
                            </span>
                        </a>


                        <a class=""w-full font-thin text-gray-500 dark:text-gray-200 flex items-center p-4 my-2 tra");
                WriteLiteral(@"nsition-colors duration-200 justify-start hover:text-blue-500""
                           href=""./users.html"">
                            <span class=""text-left"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" fill=""currentColor""
                                     viewBox=""0 0 24 24"" stroke=""currentColor"">
                                    <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2""
                                          d=""M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z"" />
                                </svg>
                            </span>
                            <span class=""mx-4 text-sm font-normal"">
                                کاربران
                            </span>
                        </a>

                        <a class=""w-full font-thin text-gray-500 dark:text-gray-200 flex items-center p-4 my-2 transition-colors duration-200 ju");
                WriteLiteral(@"stify-start hover:text-blue-500""
                           href=""./form.html"">
                            <span class=""text-left"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" viewBox=""0 0 20 20""
                                     fill=""currentColor"">
                                    <path d=""M3 4a1 1 0 011-1h12a1 1 0 011 1v2a1 1 0 01-1 1H4a1 1 0 01-1-1V4zM3 10a1 1 0 011-1h6a1 1 0 011 1v6a1 1 0 01-1 1H4a1 1 0 01-1-1v-6zM14 9a1 1 0 00-1 1v6a1 1 0 001 1h2a1 1 0 001-1v-6a1 1 0 00-1-1h-2z"" />
                                </svg>
                            </span>
                            <span class=""mx-4 text-sm font-normal"">
                                فرم ها
                            </span>
                        </a>


                        <a class=""w-full font-thin   text-gray-500 dark:text-gray-200 flex items-center p-4 my-2 transition-colors duration-200 justify-start hover:text-blue-500""
                           href=""./lo");
                WriteLiteral(@"gin.html"">
                            <span class=""text-left"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" viewBox=""0 0 20 20""
                                     fill=""currentColor"">
                                    <path fill-rule=""evenodd""
                                          d=""M3 3a1 1 0 011 1v12a1 1 0 11-2 0V4a1 1 0 011-1zm7.707 3.293a1 1 0 010 1.414L9.414 9H17a1 1 0 110 2H9.414l1.293 1.293a1 1 0 01-1.414 1.414l-3-3a1 1 0 010-1.414l3-3a1 1 0 011.414 0z""
                                          clip-rule=""evenodd"" />
                                </svg>
                            </span>
                            <span class=""mx-4 text-sm font-normal"">
                                ورود
                            </span>
                        </a>

                        <a class=""w-full font-thin   text-gray-500 dark:text-gray-200 flex items-center p-4 my-2 transition-colors duration-200 justify-start hover:text-blue-500""
 ");
                WriteLiteral(@"                          href=""./register.html"">
                            <span class=""text-left"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-5"" viewBox=""0 0 20 20""
                                     fill=""currentColor"">
                                    <path d=""M8 9a3 3 0 100-6 3 3 0 000 6zM8 11a6 6 0 016 6H2a6 6 0 016-6zM16 7a1 1 0 10-2 0v1h-1a1 1 0 100 2h1v1a1 1 0 102 0v-1h1a1 1 0 100-2h-1V7z"" />
                                </svg>
                            </span>
                            <span class=""mx-4 text-sm font-normal"">
                                ثبت نام
                            </span>
                        </a>
                    </div>
                </nav>
                <div class=""absolute bottom-0 my-10"">
                    <a class=""text-gray-600 dark:text-gray-300 hover:text-gray-800 dark:hover:text-gray-100 transition-colors duration-200 flex items-center py-2 px-8""
                       href=""https:");
                WriteLiteral(@"//github.com/aminesmkhani/aminpanel"">
                        <svg width=""20"" xmlns=""http://www.w3.org/2000/svg"" class=""text-blue-500 h-5 w-5""
                             viewBox=""0 0 20 20"" fill=""currentColor"">
                            <path fill-rule=""evenodd""
                                  d=""M6.267 3.455a3.066 3.066 0 001.745-.723 3.066 3.066 0 013.976 0 3.066 3.066 0 001.745.723 3.066 3.066 0 012.812 2.812c.051.643.304 1.254.723 1.745a3.066 3.066 0 010 3.976 3.066 3.066 0 00-.723 1.745 3.066 3.066 0 01-2.812 2.812 3.066 3.066 0 00-1.745.723 3.066 3.066 0 01-3.976 0 3.066 3.066 0 00-1.745-.723 3.066 3.066 0 01-2.812-2.812 3.066 3.066 0 00-.723-1.745 3.066 3.066 0 010-3.976 3.066 3.066 0 00.723-1.745 3.066 3.066 0 012.812-2.812zm7.44 5.252a1 1 0 00-1.414-1.414L9 10.586 7.707 9.293a1 1 0 00-1.414 1.414l2 2a1 1 0 001.414 0l4-4z""
                                  clip-rule=""evenodd"" />
                        </svg>
                        <span class=""mx-4"">
                            امین پن");
                WriteLiteral(@"ل
                        </span>
                    </a>
                </div>
            </div>
        </div>
        <!-- End Navbar  -->
        <div class=""flex flex-col w-full pl-0 md:p-4 md:space-y-4"">
            <!-- Header -->
            <header class=""w-full shadow-lg bg-white dark:bg-gray-700 items-center h-16 rounded-2xl z-40"">
                <div class=""relative z-20 flex flex-col justify-center h-full px-3 mx-auto flex-center"">
                    <div class=""relative items-center pl-1 flex w-full lg:max-w-68 sm:pr-2 sm:ml-0"">
                        <div class=""container relative left-0 z-50 flex w-3/4 h-auto h-full"">
                            <div class=""relative flex items-center w-full lg:w-64 h-full group"">
                                <div class=""absolute z-50 flex items-center justify-center block w-auto h-10 p-3 pr-2 text-sm text-gray-500  cursor-pointer sm:hidden"">
                                    <svg fill=""none"" class=""relative w-5 h-5"" stroke-linecap=""ro");
                WriteLiteral(@"und""
                                         stroke-linejoin=""round"" stroke-width=""2"" stroke=""currentColor""
                                         viewBox=""0 0 24 24"">
                                        <path d=""M10 14l2-2m0 0l2-2m-2 2l-2-2m2 2l2 2m7-2a9 9 0 11-18 0 9 9 0 0118 0z"">
                                        </path>
                                    </svg>
                                </div>
                                <svg class=""absolute right-0 z-20 hidden w-4 h-4 mr-4 text-gray-500 pointer-events-none fill-current group-hover:text-gray-400 sm:block""
                                     xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20"">
                                    <path d=""M12.9 14.32a8 8 0 1 1 1.41-1.41l5.35 5.33-1.42 1.42-5.33-5.34zM8 14A6 6 0 1 0 8 2a6 6 0 0 0 0 12z"">
                                    </path>
                                </svg>
                                <input type=""text""
                                       class=""blo");
                WriteLiteral(@"ck w-full py-1.5 pr-10 pl-4 leading-normal rounded-2xl focus:border-transparent focus:outline-none focus:ring-2 focus:ring-blue-500 ring-opacity-90 bg-gray-100 dark:bg-gray-800 text-gray-400 aa-input""
                                       placeholder=""جستجو"" />
                            </div>
                        </div>
                        <div class=""relative p-1 flex items-center justify-end w-1/4 ml-5 mr-4 sm:mr-0 sm:right-auto"">
                            <a href=""#"" class=""block relative"">
                                <img alt=""profil"" src=""../src/images/amin.jpg""
                                     class=""mx-auto object-cover rounded-full h-10 w-10 "" />
                            </a>
                        </div>
                    </div>
                </div>
            </header>
            <!-- Header -->
            
            
            ");
#nullable restore
#line 158 "C:\Users\A\source\repos\VigiStore\ServiceHost\Areas\Administration\Pages\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    function closeAlert() {\r\n        var element = document.getElementById(\"alert1\");\r\n        element.classList.add(\"hidden\");\r\n    }\r\n</script>\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
