﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullMVCProject.Models;

namespace FullMVCProject.Controllers
{
    public class TeamController : Controller
    {
        private PlayerModel _model;
        public TeamController() { }
        public TeamController(PlayerModel model)
        {
            _model = model;
        }
        // GET: Team
        public ViewResult Index()
        {
            ViewBag.Title = "Snap Scoccer";
            ViewBag.WelcomeMessage = "Welcome to the shop!. Check out our PLayers";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();

        }
        public ViewResult Player()
        {
            if (_model == null)
            {
                _model = new PlayerModel();
                _model.Name = "Bruno Fernandes";
                _model.Description = "Best Player in the team";
                _model.strength = 100;
            }
            PlayerModel playerModel = new PlayerModel();
            playerModel.Name = "Bruno Fernandes";
            playerModel.Description = "Best Midfielder";
            playerModel.strength = 100;


            if (_model.strength > 200)
            {
                ViewBag.SubTitle = "Best Physic";
            }
            else
            {
                ViewBag.SubTitle = "Great Shot ";
            }
            return View(_model);

        }
        public RedirectResult DVD()
        {
            return Redirect("~/Team/Player");
        }
        public ViewResult ManCity()
        {
            ViewBag.Title = "ManCity";
            ViewBag.WelcomeMessage = "Welcome to the home page of Manchester City. Manchester City Football Club is an English football club based in Manchester that competes in the Premier League, the top flight of English football. Founded in 1880 as St. Mark's (West Gorton), it became Ardwick Association Football Club in 1887 and Manchester City in 1894. The club's home ground is the Etihad Stadium in east Manchester, to which it moved in 2003, having played at Maine Road since 1923. The club adopted their sky blue home shirts in 1894 in the first season of the club's current iteration, that have been used ever since.";
            return View();
        }

        public ViewResult ManUnited()
        {
            ViewBag.Title = "ManUnited";
            ViewBag.WelcomeMessage = "Welcome to the home page of ManUnited. Manchester United Football Club is a professional football club based in Old Trafford, Greater Manchester, England, that competes in the Premier League, the top flight of English football. Nicknamed the Red Devils, the club was founded as Newton Heath LYR Football Club in 1878, changed its name to Manchester United in 1902 and moved to its current stadium, Old Trafford, in 1910.";
            return View();
        }

        public ViewResult Leicester()
        {
            ViewBag.Title = "Leicester";
            ViewBag.WelcomeMessage = "Welcome to the home page of Leicester. Leicester City Football Club is a professional football club based in Leicester in the East Midlands, England. The club competes in the Premier League, the top division of England's football league system, and plays its home matches at the King Power Stadium. The club was founded in 1884 as Leicester Fosse F.C.,[3] playing on a field near Fosse Road. They moved to Filbert Street in 1891, were elected to the Football League in 1894 and adopted the name Leicester City in 1919. They moved to the nearby Walkers Stadium in 2002, which was renamed the King Power Stadium in 2011.";
            return View();
        }

        public ViewResult Chelsea()
        {
            ViewBag.Title = "Chealsea";
            ViewBag.WelcomeMessage = "Welcome to the home page of Chealsea. Chelsea Football Club is an English professional football club based in Fulham, London. Founded in 1905, the club competes in the Premier League, the top division of English football. Chelsea are among England's most successful clubs, having won over thirty competitive honours, including six league titles and six European trophies. Their home ground is Stamford Bridge. Chelsea won their first major honour, the League championship, in 1955. The club won the FA Cup for the first time in 1970 and their first European honour, the Cup Winners' Cup, in 1971. After a period of decline in the late 1970s and 1980s, the club enjoyed a revival in the 1990s and had more success in cup competitions.";
            return View();
        }

        public ViewResult WestHam()
        {
            ViewBag.Title = "WestHam";
            ViewBag.WelcomeMessage = "Welcome to the home page of WestHam. West Ham United Football Club is an English professional football club based in Stratford, East London that compete in the Premier League, the top tier of English football. The club plays at the London Stadium, having moved from their former home, the Boleyn Ground, in 2016.The club was founded in 1895 as Thames Ironworks and reformed in 1900 as West Ham United. They moved to the Boleyn Ground in 1904, which remained their home ground for more than a century. The team initially competed in the Southern League and Western League before joining the Football League in 1919. They were promoted to the top flight in 1923, when they were also losing finalists in the first FA Cup Final held at Wembley. In 1940, the club won the inaugural Football League War Cup.";
            return View();
        }


        public ViewResult Liverpool()
        {
            ViewBag.Title = "Liverpool";
            ViewBag.WelcomeMessage = " The Liverpool Football Club is a football team from Liverpool, England. People around the globe support the club. It’s part of the world’s history and memories when it comes to playing football. Some countries in the world love Liverpool FC so much that they would support the club like its very own local team. Since they were founded in 1892, the Liverpool Football Club name was synonymous with fame and glory. Internationally, Liverpool is the most successful British club of all time with plenty of European trophies on their record. They are one of the most popular football teams in the world, with over 200 supporter clubs in at least 50 different countries. And yet, their magnificent history will forever be plagued by two of the worst stadium disasters of all time: Heysel and Hillsborough.";
            return View();


        }
        public ViewResult Tottenham()
        {
            ViewBag.Title = "Tottemham";
            ViewBag.WelcomeMessage = " During their colorful lifespan, Tottenham Hotspur were mostly known as cup specialists. They made history by becoming the first British team to win a European trophy, as well as winning the first UEFA Cup ever organized. Overall, their trophy room contains eight FA Cups, four League Cups, one Cup Winners' Cup and two UEFA Cups. In addition to their long tradition of cup success, the Spurs can also boast with two League titles in 1951 and 1961.";
            return View();


        }
        public ViewResult Everton()
        {
            ViewBag.Title = "Everton";
            ViewBag.WelcomeMessage = " Even for a club based in the Cradle of Football Everton's history is startling. In their 138 years of existence, they have spent only four years outside the top flight of English football. During this time, they have won nine League titles, five FA Cups and the 1985 Cup Winners' Cup. Since 1892, the club has been playing its home games at Goodison Park, the first major football stadium in England.";
            return View();

        }

        public ViewResult Leeds()
        {
            ViewBag.Title = "Leeds";
            ViewBag.WelcomeMessage = " Leeds United might be one of the most opinion-splitting clubs in the world. Their own supporters are ready to follow the club anywhere, which is easily evidenced by the fact that Leeds have the among the highest average attendance in the country, despite spending a lot of their time in the lower divisions of English football. On the other hand, their numerous rivalries with other clubs and a problematic off-the-field reputation have eventually made Leeds the most hated club in England. During their lifespan, Leeds have won three First Division titles, one FA Cup and one League Cup.";
            return View();
        }

        public ViewResult Arsenal()
        {
            ViewBag.Title = " Arsenal ";
            ViewBag.WelcomeMessage = " As one of the most successful and beloved clubs in England, Arsenal Football Club was always a magnet for the public. Tradition-wise, their results speak for themselves; in addition to winning 28 major domestic trophies, Arsenal hold the records for longest unbeaten streak and longest run in top flight of English football.";
            return View();

        }

        public ViewResult ManCityPlayers()
        {
            ViewBag.Title = "Manchester City - PhilFoden";
            ViewBag.WelcomeMessage = "Philip Walter Foden (born 28 May 2000) is an English professional footballer who plays as a midfielder for Premier League club Manchester City and the England national team.";
            return View();
        }
        public ViewResult ManUtdPlayers()
        {
            ViewBag.Title = "Manchester United - Bruno Fernandes";
            ViewBag.WelcomeMessage = " Bruno Miguel Borges Fernandes (European Portuguese: [ˈbɾunu fɨɾˈnɐ̃dɨʃ]; born 8 September 1994) is a Portuguese professional footballer who plays as a midfielder for Premier League club Manchester United and the Portuguese national team";
            return View();

        }

        public ViewResult LeicesterPlayers()
        {
            ViewBag.Title = "Leicester City - Jamie Vardy";
            ViewBag.WelcomeMessage = "Jamie Richard Vardy (né Gill; born 11 January 1987) is an English professional footballer who plays as a striker for Premier League club Leicester City. Vardy has also played for the England national team";
            return View();

        }

        public ViewResult ChelseaPlayers()
        {
            ViewBag.Title = "Chealsea - Mason Mount";
            ViewBag.WelcomeMessage = "Mason Tony Mount (born 10 January 1999) is an English professional footballer who plays as an attacking or central midfielder for Premier League club Chelsea and the England national team.";
            return View();
        }

        public ViewResult WestHamPlayers()
        {
            ViewBag.Title = "West Ham - Tomáš Souček";
            ViewBag.WelcomeMessage = "Tomáš Souček (Czech pronunciation: [ˈtomaːʃ ˈsou̯tʃɛk]; born 27 February 1995) is a Czech professional footballer who plays as a defensive midfielder for Premier League club West Ham United and the Czech Republic national team";
            return View();



        }

        public ViewResult LiverpoolPlayers()
        {
            ViewBag.Title = "Liverpool - Liam Millar";
            ViewBag.WelcomeMessage = " Liam Alan Millar (born September 27, 1999) is a Canadian professional football player who plays as a forward for Charlton Athletic, on loan from Premier League club Liverpool, and the Canada national team. He featured in the youth ranks of Brampton Youth SC and North Mississauga SC before moving to England to join Fulham Academy aged 13. After three years with Fulham, he joined the Liverpool Academy in 2016.";
            return View();



        }


        public ViewResult TottenhamPlayers()
        {
            ViewBag.Title = "TottenhamHotSpurs - Gareth Bale";
            ViewBag.WelcomeMessage = " Gareth Frank Bale (born 16 July 1989) is a Welsh professional footballer who plays as a winger for Premier League club Tottenham Hotspur, on loan from Real Madrid of La Liga, and the Welsh national team.Bale began his professional career at Southampton, playing at left-back and earning acclaim as a free kick specialist. Bale moved to Tottenham Hotspur in 2007, for an eventual £7 million fee. During his time at Tottenham, managerial and tactical shifts saw him transform into a more attacking player. ";
            return View();

        }

        public ViewResult EvertonPlayers()
        {
            ViewBag.Title = "Everton - James Rodriguez";
            ViewBag.WelcomeMessage = " James David Rodríguez Rubio born 12 July 1991 is a Colombian professional footballer who plays as an attacking midfielder or winger for Premier League club Everton and the Colombia national team. He has been praised for his technique, vision and playmaking skills, and often referred as one of the best players of his generation and the successor to his compatriot Carlos Valderrama.Starting his career at Envigado, and then moving to Argentina side Banfield, James became well known in Europe during his time at Porto, winning several trophies and individual awards during his three years at the club. In 2014, James moved from AS Monaco to Real Madrid for a transfer fee of £63 million, which beat the one set by Radamel Falcao and made him the most expensive Colombian football player and one of the most expensive players at the time.";
            return View();
        }




        public ViewResult LeedsPlayers()
        {
            ViewBag.Title = "Leeds United - Raphinha";
            ViewBag.WelcomeMessage = " Raphael Dias Belloli (born 14 December 1996), known as Raphinha, is a Brazilian professional footballer who plays as a winger for Premier League club Leeds United.";
            return View();

        }

            public ViewResult ArsenalPlayers()
             {
               ViewBag.Title = "Arsenal - Bukayo Saka ";
               ViewBag.WelcomeMessage = " Bukayo Ayoyinka T. M. Saka (born 5 September 2001) is an English professional footballer who plays as a winger or left-back for Premier League club Arsenal and the England national team. Saka was born in Ealing, Greater London to Nigerian parents, and attended Edward Betham CofE Primary School where he excelled in his football skills  before Greenford High School.Saka is of Nigerian descent, both of his parents immigrated to London for work from Nigeria. In one of his interviews, Saka stated the importance of his father in his footballing career, He's a massive inspiration for me. From when I was young, he always kept me grounded, kept me humble.";
               return View();


            }
    }

}