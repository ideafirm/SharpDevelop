using System;
using System.Collections;
using System.Collections.Generic;



namespace ICSharpCode.NRefactory.Parser.VB {



partial class ExpressionFinder {
	const int startOfExpression = 55;
	const int endOfStatementTerminatorAndBlock = 266;
	static BitArray GetExpectedSet(int state)
	{
		switch (state) {
			case 0:
			case 1:
				return set[0];
			case 2:
				return set[1];
			case 3:
			case 4:
				return set[2];
			case 5:
				return set[3];
			case 6:
			case 88:
			case 267:
			case 533:
				{
					BitArray a = new BitArray(239);
					return a;
				}
			case 7:
				return set[4];
			case 8:
				return set[5];
			case 9:
			case 10:
			case 20:
				{
					BitArray a = new BitArray(239);
					a.Set(142, true);
					return a;
				}
			case 11:
			case 193:
			case 199:
			case 205:
			case 244:
			case 248:
			case 298:
			case 402:
			case 408:
			case 474:
			case 520:
			case 530:
			case 541:
			case 571:
			case 607:
			case 665:
			case 682:
			case 758:
				return set[6];
			case 12:
			case 13:
			case 572:
			case 573:
			case 618:
			case 628:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(37, true);
					return a;
				}
			case 14:
			case 21:
			case 23:
			case 24:
			case 36:
			case 259:
			case 262:
			case 263:
			case 299:
			case 303:
			case 325:
			case 340:
			case 351:
			case 354:
			case 360:
			case 365:
			case 375:
			case 376:
			case 399:
			case 426:
			case 526:
			case 538:
			case 544:
			case 548:
			case 556:
			case 564:
			case 574:
			case 583:
			case 600:
			case 605:
			case 613:
			case 619:
			case 622:
			case 629:
			case 632:
			case 660:
			case 663:
			case 690:
			case 701:
			case 737:
			case 757:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					return a;
				}
			case 15:
			case 16:
				return set[7];
			case 17:
			case 18:
				return set[8];
			case 19:
			case 260:
			case 274:
			case 301:
			case 355:
			case 400:
			case 454:
			case 581:
			case 601:
			case 620:
			case 624:
			case 630:
			case 661:
			case 702:
				{
					BitArray a = new BitArray(239);
					a.Set(113, true);
					return a;
				}
			case 22:
			case 549:
			case 584:
				return set[9];
			case 25:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					return a;
				}
			case 26:
			case 27:
				return set[10];
			case 28:
			case 741:
				return set[11];
			case 29:
				return set[12];
			case 30:
				return set[13];
			case 31:
			case 32:
			case 152:
			case 217:
			case 218:
			case 268:
			case 279:
			case 280:
			case 441:
			case 442:
			case 462:
			case 463:
			case 464:
			case 465:
			case 559:
			case 560:
			case 593:
			case 594:
			case 696:
			case 697:
			case 750:
			case 751:
				return set[14];
			case 33:
			case 34:
			case 521:
			case 522:
			case 531:
			case 532:
			case 561:
			case 562:
			case 687:
				return set[15];
			case 35:
			case 37:
			case 157:
			case 168:
			case 171:
			case 187:
			case 203:
			case 221:
			case 310:
			case 335:
			case 425:
			case 438:
			case 477:
			case 537:
			case 555:
			case 563:
			case 641:
			case 644:
			case 669:
			case 672:
			case 677:
			case 689:
			case 705:
			case 707:
			case 730:
			case 733:
			case 736:
			case 742:
			case 745:
			case 763:
				return set[16];
			case 38:
			case 41:
				return set[17];
			case 39:
				return set[18];
			case 40:
			case 97:
			case 101:
			case 163:
			case 391:
			case 481:
				return set[19];
			case 42:
			case 177:
			case 184:
			case 189:
			case 253:
			case 448:
			case 473:
			case 476:
			case 595:
			case 596:
			case 657:
				{
					BitArray a = new BitArray(239);
					a.Set(37, true);
					return a;
				}
			case 43:
			case 44:
			case 165:
			case 166:
				return set[20];
			case 45:
			case 46:
			case 167:
			case 188:
			case 256:
			case 395:
			case 451:
			case 475:
			case 478:
			case 498:
			case 529:
			case 536:
			case 567:
			case 598:
			case 635:
			case 638:
			case 651:
			case 659:
			case 676:
			case 693:
			case 711:
			case 740:
			case 749:
				{
					BitArray a = new BitArray(239);
					a.Set(38, true);
					return a;
				}
			case 47:
			case 48:
				return set[21];
			case 49:
			case 179:
			case 186:
			case 397:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					return a;
				}
			case 50:
			case 51:
			case 52:
			case 54:
			case 393:
			case 394:
			case 415:
			case 416:
			case 422:
			case 423:
			case 489:
			case 490:
			case 724:
			case 725:
				return set[22];
			case 53:
			case 169:
			case 170:
			case 172:
			case 181:
			case 417:
			case 424:
			case 428:
			case 436:
			case 485:
			case 488:
			case 492:
			case 494:
			case 495:
			case 505:
			case 512:
			case 519:
			case 726:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					a.Set(38, true);
					return a;
				}
			case 55:
			case 56:
			case 70:
			case 75:
			case 76:
			case 77:
			case 83:
			case 99:
			case 155:
			case 178:
			case 180:
			case 182:
			case 185:
			case 195:
			case 197:
			case 215:
			case 239:
			case 277:
			case 287:
			case 289:
			case 290:
			case 307:
			case 324:
			case 329:
			case 338:
			case 344:
			case 346:
			case 350:
			case 353:
			case 359:
			case 370:
			case 372:
			case 373:
			case 379:
			case 396:
			case 398:
			case 418:
			case 437:
			case 467:
			case 483:
			case 484:
			case 486:
			case 487:
			case 554:
			case 640:
				return set[23];
			case 57:
			case 78:
			case 158:
				return set[24];
			case 58:
				return set[25];
			case 59:
				{
					BitArray a = new BitArray(239);
					a.Set(216, true);
					return a;
				}
			case 60:
				{
					BitArray a = new BitArray(239);
					a.Set(145, true);
					return a;
				}
			case 61:
			case 156:
				{
					BitArray a = new BitArray(239);
					a.Set(144, true);
					return a;
				}
			case 62:
				{
					BitArray a = new BitArray(239);
					a.Set(236, true);
					return a;
				}
			case 63:
				{
					BitArray a = new BitArray(239);
					a.Set(177, true);
					return a;
				}
			case 64:
				{
					BitArray a = new BitArray(239);
					a.Set(175, true);
					return a;
				}
			case 65:
				{
					BitArray a = new BitArray(239);
					a.Set(61, true);
					return a;
				}
			case 66:
				{
					BitArray a = new BitArray(239);
					a.Set(60, true);
					return a;
				}
			case 67:
				{
					BitArray a = new BitArray(239);
					a.Set(150, true);
					return a;
				}
			case 68:
				{
					BitArray a = new BitArray(239);
					a.Set(42, true);
					return a;
				}
			case 69:
				{
					BitArray a = new BitArray(239);
					a.Set(43, true);
					return a;
				}
			case 71:
			case 440:
				{
					BitArray a = new BitArray(239);
					a.Set(40, true);
					return a;
				}
			case 72:
				{
					BitArray a = new BitArray(239);
					a.Set(41, true);
					return a;
				}
			case 73:
			case 98:
			case 222:
			case 223:
			case 285:
			case 286:
			case 337:
			case 759:
				{
					BitArray a = new BitArray(239);
					a.Set(20, true);
					return a;
				}
			case 74:
				{
					BitArray a = new BitArray(239);
					a.Set(154, true);
					return a;
				}
			case 79:
			case 91:
			case 93:
			case 148:
				{
					BitArray a = new BitArray(239);
					a.Set(35, true);
					return a;
				}
			case 80:
			case 81:
				return set[26];
			case 82:
				{
					BitArray a = new BitArray(239);
					a.Set(36, true);
					return a;
				}
			case 84:
			case 100:
			case 515:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					a.Set(36, true);
					return a;
				}
			case 85:
			case 121:
				{
					BitArray a = new BitArray(239);
					a.Set(162, true);
					return a;
				}
			case 86:
			case 87:
				return set[27];
			case 89:
			case 92:
			case 149:
			case 150:
			case 153:
				return set[28];
			case 90:
			case 102:
			case 147:
				{
					BitArray a = new BitArray(239);
					a.Set(233, true);
					return a;
				}
			case 94:
				{
					BitArray a = new BitArray(239);
					a.Set(26, true);
					a.Set(36, true);
					a.Set(147, true);
					return a;
				}
			case 95:
				{
					BitArray a = new BitArray(239);
					a.Set(26, true);
					a.Set(147, true);
					return a;
				}
			case 96:
			case 706:
				{
					BitArray a = new BitArray(239);
					a.Set(26, true);
					return a;
				}
			case 103:
			case 356:
				{
					BitArray a = new BitArray(239);
					a.Set(231, true);
					return a;
				}
			case 104:
				{
					BitArray a = new BitArray(239);
					a.Set(230, true);
					return a;
				}
			case 105:
				{
					BitArray a = new BitArray(239);
					a.Set(224, true);
					return a;
				}
			case 106:
				{
					BitArray a = new BitArray(239);
					a.Set(223, true);
					return a;
				}
			case 107:
			case 302:
				{
					BitArray a = new BitArray(239);
					a.Set(218, true);
					return a;
				}
			case 108:
				{
					BitArray a = new BitArray(239);
					a.Set(213, true);
					return a;
				}
			case 109:
				{
					BitArray a = new BitArray(239);
					a.Set(212, true);
					return a;
				}
			case 110:
				{
					BitArray a = new BitArray(239);
					a.Set(211, true);
					return a;
				}
			case 111:
			case 455:
				{
					BitArray a = new BitArray(239);
					a.Set(210, true);
					return a;
				}
			case 112:
				{
					BitArray a = new BitArray(239);
					a.Set(209, true);
					return a;
				}
			case 113:
				{
					BitArray a = new BitArray(239);
					a.Set(206, true);
					return a;
				}
			case 114:
				{
					BitArray a = new BitArray(239);
					a.Set(203, true);
					return a;
				}
			case 115:
			case 362:
				{
					BitArray a = new BitArray(239);
					a.Set(197, true);
					return a;
				}
			case 116:
			case 606:
			case 625:
				{
					BitArray a = new BitArray(239);
					a.Set(186, true);
					return a;
				}
			case 117:
				{
					BitArray a = new BitArray(239);
					a.Set(184, true);
					return a;
				}
			case 118:
				{
					BitArray a = new BitArray(239);
					a.Set(176, true);
					return a;
				}
			case 119:
				{
					BitArray a = new BitArray(239);
					a.Set(170, true);
					return a;
				}
			case 120:
			case 319:
			case 326:
			case 341:
				{
					BitArray a = new BitArray(239);
					a.Set(163, true);
					return a;
				}
			case 122:
				{
					BitArray a = new BitArray(239);
					a.Set(147, true);
					return a;
				}
			case 123:
			case 226:
			case 231:
			case 233:
				{
					BitArray a = new BitArray(239);
					a.Set(146, true);
					return a;
				}
			case 124:
			case 228:
			case 232:
				{
					BitArray a = new BitArray(239);
					a.Set(143, true);
					return a;
				}
			case 125:
				{
					BitArray a = new BitArray(239);
					a.Set(139, true);
					return a;
				}
			case 126:
				{
					BitArray a = new BitArray(239);
					a.Set(133, true);
					return a;
				}
			case 127:
			case 261:
				{
					BitArray a = new BitArray(239);
					a.Set(127, true);
					return a;
				}
			case 128:
			case 151:
			case 251:
				{
					BitArray a = new BitArray(239);
					a.Set(126, true);
					return a;
				}
			case 129:
				{
					BitArray a = new BitArray(239);
					a.Set(124, true);
					return a;
				}
			case 130:
				{
					BitArray a = new BitArray(239);
					a.Set(121, true);
					return a;
				}
			case 131:
			case 196:
				{
					BitArray a = new BitArray(239);
					a.Set(116, true);
					return a;
				}
			case 132:
				{
					BitArray a = new BitArray(239);
					a.Set(108, true);
					return a;
				}
			case 133:
				{
					BitArray a = new BitArray(239);
					a.Set(107, true);
					return a;
				}
			case 134:
				{
					BitArray a = new BitArray(239);
					a.Set(104, true);
					return a;
				}
			case 135:
			case 652:
				{
					BitArray a = new BitArray(239);
					a.Set(98, true);
					return a;
				}
			case 136:
				{
					BitArray a = new BitArray(239);
					a.Set(87, true);
					return a;
				}
			case 137:
				{
					BitArray a = new BitArray(239);
					a.Set(84, true);
					return a;
				}
			case 138:
			case 208:
			case 238:
				{
					BitArray a = new BitArray(239);
					a.Set(70, true);
					return a;
				}
			case 139:
				{
					BitArray a = new BitArray(239);
					a.Set(67, true);
					return a;
				}
			case 140:
				{
					BitArray a = new BitArray(239);
					a.Set(66, true);
					return a;
				}
			case 141:
				{
					BitArray a = new BitArray(239);
					a.Set(65, true);
					return a;
				}
			case 142:
				{
					BitArray a = new BitArray(239);
					a.Set(64, true);
					return a;
				}
			case 143:
				{
					BitArray a = new BitArray(239);
					a.Set(62, true);
					return a;
				}
			case 144:
			case 250:
				{
					BitArray a = new BitArray(239);
					a.Set(58, true);
					return a;
				}
			case 145:
				{
					BitArray a = new BitArray(239);
					a.Set(2, true);
					return a;
				}
			case 146:
				return set[29];
			case 154:
				return set[30];
			case 159:
				return set[31];
			case 160:
				return set[32];
			case 161:
			case 162:
			case 479:
			case 480:
				return set[33];
			case 164:
				return set[34];
			case 173:
			case 174:
			case 322:
			case 331:
				return set[35];
			case 175:
			case 457:
				return set[36];
			case 176:
			case 378:
				{
					BitArray a = new BitArray(239);
					a.Set(135, true);
					return a;
				}
			case 183:
				return set[37];
			case 190:
				{
					BitArray a = new BitArray(239);
					a.Set(58, true);
					a.Set(126, true);
					return a;
				}
			case 191:
			case 192:
				return set[38];
			case 194:
				{
					BitArray a = new BitArray(239);
					a.Set(171, true);
					return a;
				}
			case 198:
			case 212:
			case 230:
			case 235:
			case 241:
			case 243:
			case 247:
			case 249:
				return set[39];
			case 200:
			case 201:
				{
					BitArray a = new BitArray(239);
					a.Set(63, true);
					a.Set(138, true);
					return a;
				}
			case 202:
			case 204:
			case 323:
				{
					BitArray a = new BitArray(239);
					a.Set(138, true);
					return a;
				}
			case 206:
			case 207:
			case 209:
			case 211:
			case 213:
			case 214:
			case 224:
			case 229:
			case 234:
			case 242:
			case 246:
			case 272:
			case 276:
				return set[40];
			case 210:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					a.Set(143, true);
					return a;
				}
			case 216:
				return set[41];
			case 219:
			case 281:
				return set[42];
			case 220:
			case 282:
				return set[43];
			case 225:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					a.Set(70, true);
					return a;
				}
			case 227:
				{
					BitArray a = new BitArray(239);
					a.Set(133, true);
					a.Set(143, true);
					a.Set(146, true);
					return a;
				}
			case 236:
			case 237:
				return set[44];
			case 240:
				{
					BitArray a = new BitArray(239);
					a.Set(64, true);
					a.Set(104, true);
					return a;
				}
			case 245:
				return set[45];
			case 252:
			case 558:
			case 681:
			case 695:
			case 703:
				{
					BitArray a = new BitArray(239);
					a.Set(127, true);
					a.Set(210, true);
					return a;
				}
			case 254:
			case 255:
			case 449:
			case 450:
			case 527:
			case 528:
			case 534:
			case 535:
			case 633:
			case 634:
			case 636:
			case 637:
			case 649:
			case 650:
			case 674:
			case 675:
			case 691:
			case 692:
				return set[46];
			case 257:
			case 258:
				return set[47];
			case 264:
			case 265:
				return set[48];
			case 266:
				return set[49];
			case 269:
				return set[50];
			case 270:
			case 271:
			case 384:
				return set[51];
			case 273:
			case 278:
			case 368:
			case 670:
			case 671:
			case 673:
			case 714:
			case 731:
			case 732:
			case 734:
			case 743:
			case 744:
			case 746:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(22, true);
					return a;
				}
			case 275:
				{
					BitArray a = new BitArray(239);
					a.Set(226, true);
					return a;
				}
			case 283:
			case 284:
				return set[52];
			case 288:
			case 330:
			case 345:
			case 407:
				return set[53];
			case 291:
			case 292:
			case 312:
			case 313:
			case 327:
			case 328:
			case 342:
			case 343:
				return set[54];
			case 293:
			case 385:
			case 388:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(111, true);
					return a;
				}
			case 294:
				{
					BitArray a = new BitArray(239);
					a.Set(108, true);
					a.Set(124, true);
					a.Set(231, true);
					return a;
				}
			case 295:
				return set[55];
			case 296:
			case 315:
				return set[56];
			case 297:
				{
					BitArray a = new BitArray(239);
					a.Set(5, true);
					return a;
				}
			case 300:
				{
					BitArray a = new BitArray(239);
					a.Set(75, true);
					a.Set(113, true);
					a.Set(123, true);
					return a;
				}
			case 304:
			case 305:
				return set[57];
			case 306:
			case 311:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(229, true);
					return a;
				}
			case 308:
			case 309:
				return set[58];
			case 314:
				return set[59];
			case 316:
				{
					BitArray a = new BitArray(239);
					a.Set(118, true);
					return a;
				}
			case 317:
			case 318:
				return set[60];
			case 320:
			case 321:
				return set[61];
			case 332:
			case 333:
				return set[62];
			case 334:
				return set[63];
			case 336:
				{
					BitArray a = new BitArray(239);
					a.Set(20, true);
					a.Set(138, true);
					return a;
				}
			case 339:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(205, true);
					return a;
				}
			case 347:
				return set[64];
			case 348:
			case 352:
				{
					BitArray a = new BitArray(239);
					a.Set(152, true);
					return a;
				}
			case 349:
				return set[65];
			case 357:
			case 358:
				return set[66];
			case 361:
				{
					BitArray a = new BitArray(239);
					a.Set(74, true);
					a.Set(113, true);
					return a;
				}
			case 363:
			case 364:
				return set[67];
			case 366:
			case 367:
				return set[68];
			case 369:
			case 371:
				return set[69];
			case 374:
			case 380:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(214, true);
					return a;
				}
			case 377:
				{
					BitArray a = new BitArray(239);
					a.Set(111, true);
					a.Set(112, true);
					a.Set(113, true);
					return a;
				}
			case 381:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(135, true);
					return a;
				}
			case 382:
			case 383:
			case 452:
			case 453:
				return set[70];
			case 386:
			case 387:
			case 389:
			case 390:
				return set[71];
			case 392:
				return set[72];
			case 401:
				{
					BitArray a = new BitArray(239);
					a.Set(211, true);
					a.Set(233, true);
					return a;
				}
			case 403:
			case 404:
			case 409:
			case 410:
				return set[73];
			case 405:
			case 411:
				return set[74];
			case 406:
			case 414:
			case 421:
				return set[75];
			case 412:
			case 413:
			case 419:
			case 420:
			case 721:
			case 722:
				return set[76];
			case 427:
			case 429:
			case 430:
			case 597:
			case 658:
				return set[77];
			case 431:
			case 432:
				return set[78];
			case 433:
			case 434:
				return set[79];
			case 435:
			case 439:
				{
					BitArray a = new BitArray(239);
					a.Set(20, true);
					a.Set(22, true);
					a.Set(38, true);
					return a;
				}
			case 443:
			case 447:
				return set[80];
			case 444:
			case 445:
				return set[81];
			case 446:
				{
					BitArray a = new BitArray(239);
					a.Set(21, true);
					return a;
				}
			case 456:
				return set[82];
			case 458:
			case 471:
				return set[83];
			case 459:
			case 472:
				return set[84];
			case 460:
			case 461:
				{
					BitArray a = new BitArray(239);
					a.Set(10, true);
					return a;
				}
			case 466:
				{
					BitArray a = new BitArray(239);
					a.Set(12, true);
					return a;
				}
			case 468:
				{
					BitArray a = new BitArray(239);
					a.Set(13, true);
					return a;
				}
			case 469:
				return set[85];
			case 470:
				return set[86];
			case 482:
				return set[87];
			case 491:
			case 493:
				return set[88];
			case 496:
			case 497:
			case 565:
			case 566:
			case 709:
			case 710:
				return set[89];
			case 499:
			case 500:
			case 501:
			case 506:
			case 507:
			case 568:
			case 712:
			case 739:
			case 748:
				return set[90];
			case 502:
			case 508:
			case 517:
				return set[91];
			case 503:
			case 504:
			case 509:
			case 510:
				{
					BitArray a = new BitArray(239);
					a.Set(22, true);
					a.Set(38, true);
					a.Set(63, true);
					return a;
				}
			case 511:
			case 513:
			case 518:
				return set[92];
			case 514:
			case 516:
				return set[93];
			case 523:
			case 542:
			case 543:
			case 599:
			case 688:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(63, true);
					return a;
				}
			case 524:
			case 525:
			case 603:
			case 604:
				return set[94];
			case 539:
			case 540:
			case 547:
				{
					BitArray a = new BitArray(239);
					a.Set(115, true);
					return a;
				}
			case 545:
			case 546:
				return set[95];
			case 550:
			case 551:
				return set[96];
			case 552:
			case 553:
			case 612:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(20, true);
					a.Set(21, true);
					return a;
				}
			case 557:
				{
					BitArray a = new BitArray(239);
					a.Set(103, true);
					return a;
				}
			case 569:
			case 570:
			case 582:
				{
					BitArray a = new BitArray(239);
					a.Set(84, true);
					a.Set(155, true);
					a.Set(209, true);
					return a;
				}
			case 575:
			case 576:
				return set[97];
			case 577:
			case 578:
				return set[98];
			case 579:
			case 580:
			case 591:
				return set[99];
			case 585:
			case 586:
				return set[100];
			case 587:
			case 588:
			case 728:
				return set[101];
			case 589:
				return set[102];
			case 590:
				return set[103];
			case 592:
			case 602:
				{
					BitArray a = new BitArray(239);
					a.Set(172, true);
					return a;
				}
			case 608:
			case 609:
				return set[104];
			case 610:
				return set[105];
			case 611:
			case 648:
				return set[106];
			case 614:
			case 615:
			case 616:
			case 639:
				return set[107];
			case 617:
			case 621:
			case 631:
				{
					BitArray a = new BitArray(239);
					a.Set(128, true);
					a.Set(198, true);
					return a;
				}
			case 623:
				return set[108];
			case 626:
				return set[109];
			case 627:
				return set[110];
			case 642:
			case 643:
			case 645:
			case 720:
			case 723:
				return set[111];
			case 646:
			case 647:
				return set[112];
			case 653:
			case 655:
			case 664:
				{
					BitArray a = new BitArray(239);
					a.Set(119, true);
					return a;
				}
			case 654:
				return set[113];
			case 656:
				return set[114];
			case 662:
				{
					BitArray a = new BitArray(239);
					a.Set(56, true);
					a.Set(189, true);
					a.Set(193, true);
					return a;
				}
			case 666:
			case 667:
				return set[115];
			case 668:
			case 678:
				{
					BitArray a = new BitArray(239);
					a.Set(1, true);
					a.Set(21, true);
					a.Set(136, true);
					return a;
				}
			case 679:
				{
					BitArray a = new BitArray(239);
					a.Set(101, true);
					return a;
				}
			case 680:
				return set[116];
			case 683:
			case 684:
				{
					BitArray a = new BitArray(239);
					a.Set(149, true);
					return a;
				}
			case 685:
			case 694:
			case 760:
				{
					BitArray a = new BitArray(239);
					a.Set(3, true);
					return a;
				}
			case 686:
				return set[117];
			case 698:
			case 699:
				return set[118];
			case 700:
			case 708:
				return set[119];
			case 704:
				return set[120];
			case 713:
			case 715:
				return set[121];
			case 716:
			case 727:
				return set[122];
			case 717:
			case 718:
				return set[123];
			case 719:
				return set[124];
			case 729:
				{
					BitArray a = new BitArray(239);
					a.Set(136, true);
					return a;
				}
			case 735:
				{
					BitArray a = new BitArray(239);
					a.Set(140, true);
					return a;
				}
			case 738:
			case 747:
				{
					BitArray a = new BitArray(239);
					a.Set(169, true);
					return a;
				}
			case 752:
				return set[125];
			case 753:
				{
					BitArray a = new BitArray(239);
					a.Set(160, true);
					return a;
				}
			case 754:
				{
					BitArray a = new BitArray(239);
					a.Set(137, true);
					return a;
				}
			case 755:
			case 756:
				return set[126];
			case 761:
				{
					BitArray a = new BitArray(239);
					a.Set(11, true);
					return a;
				}
			case 762:
				return set[127];
			case 764:
				{
					BitArray a = new BitArray(239);
					a.Set(173, true);
					return a;
				}
			case 765:
				return set[128];
			case 766:
				{
					BitArray a = new BitArray(239);
					a.Set(67, true);
					a.Set(213, true);
					return a;
				}
			case 767:
				return set[129];
			default: throw new InvalidOperationException();
		}
	}

	const bool T = true;
	const bool x = false;

	int currentState = 0;

	readonly Stack<int> stateStack = new Stack<int>();
	bool wasQualifierTokenAtStart = false;
	bool nextTokenIsPotentialStartOfExpression = false;
	bool readXmlIdentifier = false;
	bool identifierExpected = false;
	bool nextTokenIsStartOfImportsOrAccessExpression = false;
	bool isMissingModifier = false;
	bool isAlreadyInExpr = false;
	bool wasNormalAttribute = false;
	int activeArgument = 0;
	List<Token> errors = new List<Token>();
	
	public ExpressionFinder()
	{
		stateStack.Push(-1); // required so that we don't crash when leaving the root production
	}

	void Expect(int expectedKind, Token la)
	{
		if (la.kind != expectedKind) {
			Error(la);
			output.AppendLine("expected: " + expectedKind);
			//Console.WriteLine("expected: " + expectedKind);
		}
	}
	
	void Error(Token la) 
	{
		output.AppendLine("not expected: " + la);
		//Console.WriteLine("not expected: " + la);
		errors.Add(la);
	}
	
	Token t;
	
	public void InformToken(Token la) 
	{
		switchlbl: switch (currentState) {
			case 0: {
				PushContext(Context.Global, la, t);
				goto case 1;
			}
			case 1: {
				if (la == null) { currentState = 1; break; }
				if (la.kind == 173) {
					stateStack.Push(1);
					goto case 764;
				} else {
					goto case 2;
				}
			}
			case 2: {
				if (la == null) { currentState = 2; break; }
				if (la.kind == 137) {
					stateStack.Push(2);
					goto case 754;
				} else {
					goto case 3;
				}
			}
			case 3: {
				if (la == null) { currentState = 3; break; }
				if (la.kind == 40) {
					stateStack.Push(3);
					goto case 440;
				} else {
					goto case 4;
				}
			}
			case 4: {
				if (la == null) { currentState = 4; break; }
				if (set[3].Get(la.kind)) {
					stateStack.Push(4);
					goto case 5;
				} else {
					PopContext();
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 5: {
				if (la == null) { currentState = 5; break; }
				if (la.kind == 160) {
					currentState = 750;
					break;
				} else {
					if (set[4].Get(la.kind)) {
						goto case 7;
					} else {
						goto case 6;
					}
				}
			}
			case 6: {
				Error(la);
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 7: {
				if (la == null) { currentState = 7; break; }
				if (la.kind == 40) {
					stateStack.Push(7);
					goto case 440;
				} else {
					goto case 8;
				}
			}
			case 8: {
				if (la == null) { currentState = 8; break; }
				if (set[130].Get(la.kind)) {
					currentState = 8;
					break;
				} else {
					if (la.kind == 84 || la.kind == 155 || la.kind == 209) {
						goto case 569;
					} else {
						if (la.kind == 103) {
							currentState = 558;
							break;
						} else {
							if (la.kind == 115) {
								goto case 539;
							} else {
								if (la.kind == 142) {
									goto case 9;
								} else {
									goto case 6;
								}
							}
						}
					}
				}
			}
			case 9: {
				PushContext(Context.TypeDeclaration, la, t);
				goto case 10;
			}
			case 10: {
				if (la == null) { currentState = 10; break; }
				Expect(142, la); // "Interface"
				currentState = 11;
				break;
			}
			case 11: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(12);
				goto case 205;
			}
			case 12: {
				PopContext();
				goto case 13;
			}
			case 13: {
				if (la == null) { currentState = 13; break; }
				if (la.kind == 37) {
					currentState = 747;
					break;
				} else {
					goto case 14;
				}
			}
			case 14: {
				stateStack.Push(15);
				goto case 23;
			}
			case 15: {
				isMissingModifier = true;
				goto case 16;
			}
			case 16: {
				if (la == null) { currentState = 16; break; }
				if (la.kind == 140) {
					currentState = 742;
					break;
				} else {
					goto case 17;
				}
			}
			case 17: {
				isMissingModifier = true;
				goto case 18;
			}
			case 18: {
				if (la == null) { currentState = 18; break; }
				if (set[10].Get(la.kind)) {
					goto case 26;
				} else {
					isMissingModifier = false;
					goto case 19;
				}
			}
			case 19: {
				if (la == null) { currentState = 19; break; }
				Expect(113, la); // "End"
				currentState = 20;
				break;
			}
			case 20: {
				if (la == null) { currentState = 20; break; }
				Expect(142, la); // "Interface"
				currentState = 21;
				break;
			}
			case 21: {
				stateStack.Push(22);
				goto case 23;
			}
			case 22: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 23: {
				if (la != null) CurrentBlock.lastExpressionStart = la.Location;
				goto case 24;
			}
			case 24: {
				if (la == null) { currentState = 24; break; }
				if (la.kind == 1) {
					goto case 25;
				} else {
					if (la.kind == 21) {
						currentState = stateStack.Pop();
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 25: {
				if (la == null) { currentState = 25; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 26: {
				isMissingModifier = true;
				goto case 27;
			}
			case 27: {
				if (la == null) { currentState = 27; break; }
				if (la.kind == 40) {
					stateStack.Push(26);
					goto case 440;
				} else {
					isMissingModifier = true;
					goto case 28;
				}
			}
			case 28: {
				if (la == null) { currentState = 28; break; }
				if (set[131].Get(la.kind)) {
					currentState = 741;
					break;
				} else {
					isMissingModifier = false;
					goto case 29;
				}
			}
			case 29: {
				if (la == null) { currentState = 29; break; }
				if (la.kind == 84 || la.kind == 155 || la.kind == 209) {
					stateStack.Push(17);
					goto case 569;
				} else {
					if (la.kind == 103) {
						stateStack.Push(17);
						goto case 557;
					} else {
						if (la.kind == 115) {
							stateStack.Push(17);
							goto case 539;
						} else {
							if (la.kind == 142) {
								stateStack.Push(17);
								goto case 9;
							} else {
								if (set[13].Get(la.kind)) {
									stateStack.Push(17);
									goto case 30;
								} else {
									Error(la);
									goto case 17;
								}
							}
						}
					}
				}
			}
			case 30: {
				if (la == null) { currentState = 30; break; }
				if (la.kind == 119) {
					currentState = 530;
					break;
				} else {
					if (la.kind == 186) {
						currentState = 520;
						break;
					} else {
						if (la.kind == 127 || la.kind == 210) {
							currentState = 31;
							break;
						} else {
							goto case 6;
						}
					}
				}
			}
			case 31: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				goto case 32;
			}
			case 32: {
				if (la == null) { currentState = 32; break; }
				currentState = 33;
				break;
			}
			case 33: {
				PopContext();
				goto case 34;
			}
			case 34: {
				if (la == null) { currentState = 34; break; }
				if (la.kind == 37) {
					currentState = 496;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 35;
						break;
					} else {
						goto case 23;
					}
				}
			}
			case 35: {
				PushContext(Context.Type, la, t);
				stateStack.Push(36);
				goto case 37;
			}
			case 36: {
				PopContext();
				goto case 23;
			}
			case 37: {
				if (la == null) { currentState = 37; break; }
				if (la.kind == 130) {
					currentState = 38;
					break;
				} else {
					if (set[6].Get(la.kind)) {
						currentState = 38;
						break;
					} else {
						if (set[132].Get(la.kind)) {
							currentState = 38;
							break;
						} else {
							if (la.kind == 33) {
								currentState = 38;
								break;
							} else {
								Error(la);
								goto case 38;
							}
						}
					}
				}
			}
			case 38: {
				if (la == null) { currentState = 38; break; }
				if (la.kind == 37) {
					stateStack.Push(38);
					goto case 42;
				} else {
					goto case 39;
				}
			}
			case 39: {
				if (la == null) { currentState = 39; break; }
				if (la.kind == 26) {
					currentState = 40;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 40: {
				stateStack.Push(41);
				goto case 101;
			}
			case 41: {
				if (la == null) { currentState = 41; break; }
				if (la.kind == 37) {
					stateStack.Push(41);
					goto case 42;
				} else {
					goto case 39;
				}
			}
			case 42: {
				if (la == null) { currentState = 42; break; }
				Expect(37, la); // "("
				currentState = 43;
				break;
			}
			case 43: {
				PushContext(Context.Expression, la, t);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 44;
			}
			case 44: {
				if (la == null) { currentState = 44; break; }
				if (la.kind == 169) {
					currentState = 491;
					break;
				} else {
					if (set[22].Get(la.kind)) {
						if (set[21].Get(la.kind)) {
							stateStack.Push(45);
							goto case 47;
						} else {
							goto case 45;
						}
					} else {
						Error(la);
						goto case 45;
					}
				}
			}
			case 45: {
				PopContext();
				goto case 46;
			}
			case 46: {
				if (la == null) { currentState = 46; break; }
				Expect(38, la); // ")"
				currentState = stateStack.Pop();
				break;
			}
			case 47: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 48;
			}
			case 48: {
				if (la == null) { currentState = 48; break; }
				if (set[23].Get(la.kind)) {
					activeArgument = 0;
					goto case 487;
				} else {
					if (la.kind == 22) {
						activeArgument = 0;
						goto case 49;
					} else {
						goto case 6;
					}
				}
			}
			case 49: {
				if (la == null) { currentState = 49; break; }
				Expect(22, la); // ","
				currentState = 50;
				break;
			}
			case 50: {
				activeArgument++;
				goto case 51;
			}
			case 51: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 52;
			}
			case 52: {
				if (la == null) { currentState = 52; break; }
				if (set[23].Get(la.kind)) {
					stateStack.Push(53);
					goto case 55;
				} else {
					goto case 53;
				}
			}
			case 53: {
				if (la == null) { currentState = 53; break; }
				if (la.kind == 22) {
					currentState = 54;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 54: {
				activeArgument++;
				goto case 51;
			}
			case 55: {
				PushContext(Context.Expression, la, t);
				goto case 56;
			}
			case 56: {
				stateStack.Push(57);
				goto case 75;
			}
			case 57: {
				if (la == null) { currentState = 57; break; }
				if (set[25].Get(la.kind)) {
					stateStack.Push(56);
					goto case 58;
				} else {
					PopContext();
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 58: {
				if (la == null) { currentState = 58; break; }
				if (la.kind == 31) {
					currentState = stateStack.Pop();
					break;
				} else {
					if (la.kind == 30) {
						currentState = stateStack.Pop();
						break;
					} else {
						if (la.kind == 34) {
							currentState = stateStack.Pop();
							break;
						} else {
							if (la.kind == 25) {
								currentState = stateStack.Pop();
								break;
							} else {
								if (la.kind == 24) {
									currentState = stateStack.Pop();
									break;
								} else {
									if (la.kind == 32) {
										currentState = stateStack.Pop();
										break;
									} else {
										if (la.kind == 154) {
											goto case 74;
										} else {
											if (la.kind == 20) {
												goto case 73;
											} else {
												if (la.kind == 41) {
													goto case 72;
												} else {
													if (la.kind == 40) {
														goto case 71;
													} else {
														if (la.kind == 39) {
															currentState = 70;
															break;
														} else {
															if (la.kind == 43) {
																goto case 69;
															} else {
																if (la.kind == 42) {
																	goto case 68;
																} else {
																	if (la.kind == 150) {
																		goto case 67;
																	} else {
																		if (la.kind == 23) {
																			currentState = stateStack.Pop();
																			break;
																		} else {
																			if (la.kind == 60) {
																				goto case 66;
																			} else {
																				if (la.kind == 61) {
																					goto case 65;
																				} else {
																					if (la.kind == 175) {
																						goto case 64;
																					} else {
																						if (la.kind == 177) {
																							goto case 63;
																						} else {
																							if (la.kind == 236) {
																								goto case 62;
																							} else {
																								if (la.kind == 44) {
																									currentState = stateStack.Pop();
																									break;
																								} else {
																									if (la.kind == 45) {
																										currentState = stateStack.Pop();
																										break;
																									} else {
																										if (la.kind == 144) {
																											goto case 61;
																										} else {
																											if (la.kind == 145) {
																												goto case 60;
																											} else {
																												if (la.kind == 47) {
																													currentState = stateStack.Pop();
																													break;
																												} else {
																													if (la.kind == 49) {
																														currentState = stateStack.Pop();
																														break;
																													} else {
																														if (la.kind == 50) {
																															currentState = stateStack.Pop();
																															break;
																														} else {
																															if (la.kind == 51) {
																																currentState = stateStack.Pop();
																																break;
																															} else {
																																if (la.kind == 46) {
																																	currentState = stateStack.Pop();
																																	break;
																																} else {
																																	if (la.kind == 48) {
																																		currentState = stateStack.Pop();
																																		break;
																																	} else {
																																		if (la.kind == 54) {
																																			currentState = stateStack.Pop();
																																			break;
																																		} else {
																																			if (la.kind == 52) {
																																				currentState = stateStack.Pop();
																																				break;
																																			} else {
																																				if (la.kind == 53) {
																																					currentState = stateStack.Pop();
																																					break;
																																				} else {
																																					if (la.kind == 216) {
																																						goto case 59;
																																					} else {
																																						if (la.kind == 55) {
																																							currentState = stateStack.Pop();
																																							break;
																																						} else {
																																							goto case 6;
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 59: {
				if (la == null) { currentState = 59; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 60: {
				if (la == null) { currentState = 60; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 61: {
				if (la == null) { currentState = 61; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 62: {
				if (la == null) { currentState = 62; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 63: {
				if (la == null) { currentState = 63; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 64: {
				if (la == null) { currentState = 64; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 65: {
				if (la == null) { currentState = 65; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 66: {
				if (la == null) { currentState = 66; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 67: {
				if (la == null) { currentState = 67; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 68: {
				if (la == null) { currentState = 68; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 69: {
				if (la == null) { currentState = 69; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 70: {
				wasNormalAttribute = false;
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 71: {
				if (la == null) { currentState = 71; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 72: {
				if (la == null) { currentState = 72; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 73: {
				if (la == null) { currentState = 73; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 74: {
				if (la == null) { currentState = 74; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 75: {
				PushContext(Context.Expression, la, t);
				goto case 76;
			}
			case 76: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 77;
			}
			case 77: {
				if (la == null) { currentState = 77; break; }
				if (set[133].Get(la.kind)) {
					currentState = 76;
					break;
				} else {
					if (set[35].Get(la.kind)) {
						stateStack.Push(159);
						goto case 173;
					} else {
						if (la.kind == 220) {
							currentState = 155;
							break;
						} else {
							if (la.kind == 162) {
								stateStack.Push(78);
								goto case 85;
							} else {
								if (la.kind == 35) {
									stateStack.Push(78);
									goto case 79;
								} else {
									Error(la);
									goto case 78;
								}
							}
						}
					}
				}
			}
			case 78: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 79: {
				if (la == null) { currentState = 79; break; }
				Expect(35, la); // "{"
				currentState = 80;
				break;
			}
			case 80: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 81;
			}
			case 81: {
				if (la == null) { currentState = 81; break; }
				if (set[23].Get(la.kind)) {
					goto case 83;
				} else {
					goto case 82;
				}
			}
			case 82: {
				if (la == null) { currentState = 82; break; }
				Expect(36, la); // "}"
				currentState = stateStack.Pop();
				break;
			}
			case 83: {
				stateStack.Push(84);
				goto case 55;
			}
			case 84: {
				if (la == null) { currentState = 84; break; }
				if (la.kind == 22) {
					currentState = 83;
					break;
				} else {
					goto case 82;
				}
			}
			case 85: {
				if (la == null) { currentState = 85; break; }
				Expect(162, la); // "New"
				currentState = 86;
				break;
			}
			case 86: {
				PushContext(Context.ObjectCreation, la, t);
				goto case 87;
			}
			case 87: {
				if (la == null) { currentState = 87; break; }
				if (set[16].Get(la.kind)) {
					stateStack.Push(146);
					goto case 37;
				} else {
					if (la.kind == 233) {
						PushContext(Context.ObjectInitializer, la, t);
						goto case 90;
					} else {
						goto case 88;
					}
				}
			}
			case 88: {
				Error(la);
				goto case 89;
			}
			case 89: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 90: {
				if (la == null) { currentState = 90; break; }
				Expect(233, la); // "With"
				currentState = 91;
				break;
			}
			case 91: {
				stateStack.Push(92);
				goto case 93;
			}
			case 92: {
				PopContext();
				goto case 89;
			}
			case 93: {
				if (la == null) { currentState = 93; break; }
				Expect(35, la); // "{"
				currentState = 94;
				break;
			}
			case 94: {
				if (la == null) { currentState = 94; break; }
				if (la.kind == 26 || la.kind == 147) {
					goto case 95;
				} else {
					goto case 82;
				}
			}
			case 95: {
				if (la == null) { currentState = 95; break; }
				if (la.kind == 147) {
					currentState = 96;
					break;
				} else {
					goto case 96;
				}
			}
			case 96: {
				if (la == null) { currentState = 96; break; }
				Expect(26, la); // "."
				currentState = 97;
				break;
			}
			case 97: {
				stateStack.Push(98);
				goto case 101;
			}
			case 98: {
				if (la == null) { currentState = 98; break; }
				Expect(20, la); // "="
				currentState = 99;
				break;
			}
			case 99: {
				stateStack.Push(100);
				goto case 55;
			}
			case 100: {
				if (la == null) { currentState = 100; break; }
				if (la.kind == 22) {
					currentState = 95;
					break;
				} else {
					goto case 82;
				}
			}
			case 101: {
				if (la == null) { currentState = 101; break; }
				if (la.kind == 2) {
					goto case 145;
				} else {
					if (la.kind == 56) {
						currentState = stateStack.Pop();
						break;
					} else {
						if (la.kind == 57) {
							currentState = stateStack.Pop();
							break;
						} else {
							if (la.kind == 58) {
								goto case 144;
							} else {
								if (la.kind == 59) {
									currentState = stateStack.Pop();
									break;
								} else {
									if (la.kind == 60) {
										goto case 66;
									} else {
										if (la.kind == 61) {
											goto case 65;
										} else {
											if (la.kind == 62) {
												goto case 143;
											} else {
												if (la.kind == 63) {
													currentState = stateStack.Pop();
													break;
												} else {
													if (la.kind == 64) {
														goto case 142;
													} else {
														if (la.kind == 65) {
															goto case 141;
														} else {
															if (la.kind == 66) {
																goto case 140;
															} else {
																if (la.kind == 67) {
																	goto case 139;
																} else {
																	if (la.kind == 68) {
																		currentState = stateStack.Pop();
																		break;
																	} else {
																		if (la.kind == 69) {
																			currentState = stateStack.Pop();
																			break;
																		} else {
																			if (la.kind == 70) {
																				goto case 138;
																			} else {
																				if (la.kind == 71) {
																					currentState = stateStack.Pop();
																					break;
																				} else {
																					if (la.kind == 72) {
																						currentState = stateStack.Pop();
																						break;
																					} else {
																						if (la.kind == 73) {
																							currentState = stateStack.Pop();
																							break;
																						} else {
																							if (la.kind == 74) {
																								currentState = stateStack.Pop();
																								break;
																							} else {
																								if (la.kind == 75) {
																									currentState = stateStack.Pop();
																									break;
																								} else {
																									if (la.kind == 76) {
																										currentState = stateStack.Pop();
																										break;
																									} else {
																										if (la.kind == 77) {
																											currentState = stateStack.Pop();
																											break;
																										} else {
																											if (la.kind == 78) {
																												currentState = stateStack.Pop();
																												break;
																											} else {
																												if (la.kind == 79) {
																													currentState = stateStack.Pop();
																													break;
																												} else {
																													if (la.kind == 80) {
																														currentState = stateStack.Pop();
																														break;
																													} else {
																														if (la.kind == 81) {
																															currentState = stateStack.Pop();
																															break;
																														} else {
																															if (la.kind == 82) {
																																currentState = stateStack.Pop();
																																break;
																															} else {
																																if (la.kind == 83) {
																																	currentState = stateStack.Pop();
																																	break;
																																} else {
																																	if (la.kind == 84) {
																																		goto case 137;
																																	} else {
																																		if (la.kind == 85) {
																																			currentState = stateStack.Pop();
																																			break;
																																		} else {
																																			if (la.kind == 86) {
																																				currentState = stateStack.Pop();
																																				break;
																																			} else {
																																				if (la.kind == 87) {
																																					goto case 136;
																																				} else {
																																					if (la.kind == 88) {
																																						currentState = stateStack.Pop();
																																						break;
																																					} else {
																																						if (la.kind == 89) {
																																							currentState = stateStack.Pop();
																																							break;
																																						} else {
																																							if (la.kind == 90) {
																																								currentState = stateStack.Pop();
																																								break;
																																							} else {
																																								if (la.kind == 91) {
																																									currentState = stateStack.Pop();
																																									break;
																																								} else {
																																									if (la.kind == 92) {
																																										currentState = stateStack.Pop();
																																										break;
																																									} else {
																																										if (la.kind == 93) {
																																											currentState = stateStack.Pop();
																																											break;
																																										} else {
																																											if (la.kind == 94) {
																																												currentState = stateStack.Pop();
																																												break;
																																											} else {
																																												if (la.kind == 95) {
																																													currentState = stateStack.Pop();
																																													break;
																																												} else {
																																													if (la.kind == 96) {
																																														currentState = stateStack.Pop();
																																														break;
																																													} else {
																																														if (la.kind == 97) {
																																															currentState = stateStack.Pop();
																																															break;
																																														} else {
																																															if (la.kind == 98) {
																																																goto case 135;
																																															} else {
																																																if (la.kind == 99) {
																																																	currentState = stateStack.Pop();
																																																	break;
																																																} else {
																																																	if (la.kind == 100) {
																																																		currentState = stateStack.Pop();
																																																		break;
																																																	} else {
																																																		if (la.kind == 101) {
																																																			currentState = stateStack.Pop();
																																																			break;
																																																		} else {
																																																			if (la.kind == 102) {
																																																				currentState = stateStack.Pop();
																																																				break;
																																																			} else {
																																																				if (la.kind == 103) {
																																																					currentState = stateStack.Pop();
																																																					break;
																																																				} else {
																																																					if (la.kind == 104) {
																																																						goto case 134;
																																																					} else {
																																																						if (la.kind == 105) {
																																																							currentState = stateStack.Pop();
																																																							break;
																																																						} else {
																																																							if (la.kind == 106) {
																																																								currentState = stateStack.Pop();
																																																								break;
																																																							} else {
																																																								if (la.kind == 107) {
																																																									goto case 133;
																																																								} else {
																																																									if (la.kind == 108) {
																																																										goto case 132;
																																																									} else {
																																																										if (la.kind == 109) {
																																																											currentState = stateStack.Pop();
																																																											break;
																																																										} else {
																																																											if (la.kind == 110) {
																																																												currentState = stateStack.Pop();
																																																												break;
																																																											} else {
																																																												if (la.kind == 111) {
																																																													currentState = stateStack.Pop();
																																																													break;
																																																												} else {
																																																													if (la.kind == 112) {
																																																														currentState = stateStack.Pop();
																																																														break;
																																																													} else {
																																																														if (la.kind == 113) {
																																																															currentState = stateStack.Pop();
																																																															break;
																																																														} else {
																																																															if (la.kind == 114) {
																																																																currentState = stateStack.Pop();
																																																																break;
																																																															} else {
																																																																if (la.kind == 115) {
																																																																	currentState = stateStack.Pop();
																																																																	break;
																																																																} else {
																																																																	if (la.kind == 116) {
																																																																		goto case 131;
																																																																	} else {
																																																																		if (la.kind == 117) {
																																																																			currentState = stateStack.Pop();
																																																																			break;
																																																																		} else {
																																																																			if (la.kind == 118) {
																																																																				currentState = stateStack.Pop();
																																																																				break;
																																																																			} else {
																																																																				if (la.kind == 119) {
																																																																					currentState = stateStack.Pop();
																																																																					break;
																																																																				} else {
																																																																					if (la.kind == 120) {
																																																																						currentState = stateStack.Pop();
																																																																						break;
																																																																					} else {
																																																																						if (la.kind == 121) {
																																																																							goto case 130;
																																																																						} else {
																																																																							if (la.kind == 122) {
																																																																								currentState = stateStack.Pop();
																																																																								break;
																																																																							} else {
																																																																								if (la.kind == 123) {
																																																																									currentState = stateStack.Pop();
																																																																									break;
																																																																								} else {
																																																																									if (la.kind == 124) {
																																																																										goto case 129;
																																																																									} else {
																																																																										if (la.kind == 125) {
																																																																											currentState = stateStack.Pop();
																																																																											break;
																																																																										} else {
																																																																											if (la.kind == 126) {
																																																																												goto case 128;
																																																																											} else {
																																																																												if (la.kind == 127) {
																																																																													goto case 127;
																																																																												} else {
																																																																													if (la.kind == 128) {
																																																																														currentState = stateStack.Pop();
																																																																														break;
																																																																													} else {
																																																																														if (la.kind == 129) {
																																																																															currentState = stateStack.Pop();
																																																																															break;
																																																																														} else {
																																																																															if (la.kind == 130) {
																																																																																currentState = stateStack.Pop();
																																																																																break;
																																																																															} else {
																																																																																if (la.kind == 131) {
																																																																																	currentState = stateStack.Pop();
																																																																																	break;
																																																																																} else {
																																																																																	if (la.kind == 132) {
																																																																																		currentState = stateStack.Pop();
																																																																																		break;
																																																																																	} else {
																																																																																		if (la.kind == 133) {
																																																																																			goto case 126;
																																																																																		} else {
																																																																																			if (la.kind == 134) {
																																																																																				currentState = stateStack.Pop();
																																																																																				break;
																																																																																			} else {
																																																																																				if (la.kind == 135) {
																																																																																					currentState = stateStack.Pop();
																																																																																					break;
																																																																																				} else {
																																																																																					if (la.kind == 136) {
																																																																																						currentState = stateStack.Pop();
																																																																																						break;
																																																																																					} else {
																																																																																						if (la.kind == 137) {
																																																																																							currentState = stateStack.Pop();
																																																																																							break;
																																																																																						} else {
																																																																																							if (la.kind == 138) {
																																																																																								currentState = stateStack.Pop();
																																																																																								break;
																																																																																							} else {
																																																																																								if (la.kind == 139) {
																																																																																									goto case 125;
																																																																																								} else {
																																																																																									if (la.kind == 140) {
																																																																																										currentState = stateStack.Pop();
																																																																																										break;
																																																																																									} else {
																																																																																										if (la.kind == 141) {
																																																																																											currentState = stateStack.Pop();
																																																																																											break;
																																																																																										} else {
																																																																																											if (la.kind == 142) {
																																																																																												currentState = stateStack.Pop();
																																																																																												break;
																																																																																											} else {
																																																																																												if (la.kind == 143) {
																																																																																													goto case 124;
																																																																																												} else {
																																																																																													if (la.kind == 144) {
																																																																																														goto case 61;
																																																																																													} else {
																																																																																														if (la.kind == 145) {
																																																																																															goto case 60;
																																																																																														} else {
																																																																																															if (la.kind == 146) {
																																																																																																goto case 123;
																																																																																															} else {
																																																																																																if (la.kind == 147) {
																																																																																																	goto case 122;
																																																																																																} else {
																																																																																																	if (la.kind == 148) {
																																																																																																		currentState = stateStack.Pop();
																																																																																																		break;
																																																																																																	} else {
																																																																																																		if (la.kind == 149) {
																																																																																																			currentState = stateStack.Pop();
																																																																																																			break;
																																																																																																		} else {
																																																																																																			if (la.kind == 150) {
																																																																																																				goto case 67;
																																																																																																			} else {
																																																																																																				if (la.kind == 151) {
																																																																																																					currentState = stateStack.Pop();
																																																																																																					break;
																																																																																																				} else {
																																																																																																					if (la.kind == 152) {
																																																																																																						currentState = stateStack.Pop();
																																																																																																						break;
																																																																																																					} else {
																																																																																																						if (la.kind == 153) {
																																																																																																							currentState = stateStack.Pop();
																																																																																																							break;
																																																																																																						} else {
																																																																																																							if (la.kind == 154) {
																																																																																																								goto case 74;
																																																																																																							} else {
																																																																																																								if (la.kind == 155) {
																																																																																																									currentState = stateStack.Pop();
																																																																																																									break;
																																																																																																								} else {
																																																																																																									if (la.kind == 156) {
																																																																																																										currentState = stateStack.Pop();
																																																																																																										break;
																																																																																																									} else {
																																																																																																										if (la.kind == 157) {
																																																																																																											currentState = stateStack.Pop();
																																																																																																											break;
																																																																																																										} else {
																																																																																																											if (la.kind == 158) {
																																																																																																												currentState = stateStack.Pop();
																																																																																																												break;
																																																																																																											} else {
																																																																																																												if (la.kind == 159) {
																																																																																																													currentState = stateStack.Pop();
																																																																																																													break;
																																																																																																												} else {
																																																																																																													if (la.kind == 160) {
																																																																																																														currentState = stateStack.Pop();
																																																																																																														break;
																																																																																																													} else {
																																																																																																														if (la.kind == 161) {
																																																																																																															currentState = stateStack.Pop();
																																																																																																															break;
																																																																																																														} else {
																																																																																																															if (la.kind == 162) {
																																																																																																																goto case 121;
																																																																																																															} else {
																																																																																																																if (la.kind == 163) {
																																																																																																																	goto case 120;
																																																																																																																} else {
																																																																																																																	if (la.kind == 164) {
																																																																																																																		currentState = stateStack.Pop();
																																																																																																																		break;
																																																																																																																	} else {
																																																																																																																		if (la.kind == 165) {
																																																																																																																			currentState = stateStack.Pop();
																																																																																																																			break;
																																																																																																																		} else {
																																																																																																																			if (la.kind == 166) {
																																																																																																																				currentState = stateStack.Pop();
																																																																																																																				break;
																																																																																																																			} else {
																																																																																																																				if (la.kind == 167) {
																																																																																																																					currentState = stateStack.Pop();
																																																																																																																					break;
																																																																																																																				} else {
																																																																																																																					if (la.kind == 168) {
																																																																																																																						currentState = stateStack.Pop();
																																																																																																																						break;
																																																																																																																					} else {
																																																																																																																						if (la.kind == 169) {
																																																																																																																							currentState = stateStack.Pop();
																																																																																																																							break;
																																																																																																																						} else {
																																																																																																																							if (la.kind == 170) {
																																																																																																																								goto case 119;
																																																																																																																							} else {
																																																																																																																								if (la.kind == 171) {
																																																																																																																									currentState = stateStack.Pop();
																																																																																																																									break;
																																																																																																																								} else {
																																																																																																																									if (la.kind == 172) {
																																																																																																																										currentState = stateStack.Pop();
																																																																																																																										break;
																																																																																																																									} else {
																																																																																																																										if (la.kind == 173) {
																																																																																																																											currentState = stateStack.Pop();
																																																																																																																											break;
																																																																																																																										} else {
																																																																																																																											if (la.kind == 174) {
																																																																																																																												currentState = stateStack.Pop();
																																																																																																																												break;
																																																																																																																											} else {
																																																																																																																												if (la.kind == 175) {
																																																																																																																													goto case 64;
																																																																																																																												} else {
																																																																																																																													if (la.kind == 176) {
																																																																																																																														goto case 118;
																																																																																																																													} else {
																																																																																																																														if (la.kind == 177) {
																																																																																																																															goto case 63;
																																																																																																																														} else {
																																																																																																																															if (la.kind == 178) {
																																																																																																																																currentState = stateStack.Pop();
																																																																																																																																break;
																																																																																																																															} else {
																																																																																																																																if (la.kind == 179) {
																																																																																																																																	currentState = stateStack.Pop();
																																																																																																																																	break;
																																																																																																																																} else {
																																																																																																																																	if (la.kind == 180) {
																																																																																																																																		currentState = stateStack.Pop();
																																																																																																																																		break;
																																																																																																																																	} else {
																																																																																																																																		if (la.kind == 181) {
																																																																																																																																			currentState = stateStack.Pop();
																																																																																																																																			break;
																																																																																																																																		} else {
																																																																																																																																			if (la.kind == 182) {
																																																																																																																																				currentState = stateStack.Pop();
																																																																																																																																				break;
																																																																																																																																			} else {
																																																																																																																																				if (la.kind == 183) {
																																																																																																																																					currentState = stateStack.Pop();
																																																																																																																																					break;
																																																																																																																																				} else {
																																																																																																																																					if (la.kind == 184) {
																																																																																																																																						goto case 117;
																																																																																																																																					} else {
																																																																																																																																						if (la.kind == 185) {
																																																																																																																																							currentState = stateStack.Pop();
																																																																																																																																							break;
																																																																																																																																						} else {
																																																																																																																																							if (la.kind == 186) {
																																																																																																																																								goto case 116;
																																																																																																																																							} else {
																																																																																																																																								if (la.kind == 187) {
																																																																																																																																									currentState = stateStack.Pop();
																																																																																																																																									break;
																																																																																																																																								} else {
																																																																																																																																									if (la.kind == 188) {
																																																																																																																																										currentState = stateStack.Pop();
																																																																																																																																										break;
																																																																																																																																									} else {
																																																																																																																																										if (la.kind == 189) {
																																																																																																																																											currentState = stateStack.Pop();
																																																																																																																																											break;
																																																																																																																																										} else {
																																																																																																																																											if (la.kind == 190) {
																																																																																																																																												currentState = stateStack.Pop();
																																																																																																																																												break;
																																																																																																																																											} else {
																																																																																																																																												if (la.kind == 191) {
																																																																																																																																													currentState = stateStack.Pop();
																																																																																																																																													break;
																																																																																																																																												} else {
																																																																																																																																													if (la.kind == 192) {
																																																																																																																																														currentState = stateStack.Pop();
																																																																																																																																														break;
																																																																																																																																													} else {
																																																																																																																																														if (la.kind == 193) {
																																																																																																																																															currentState = stateStack.Pop();
																																																																																																																																															break;
																																																																																																																																														} else {
																																																																																																																																															if (la.kind == 194) {
																																																																																																																																																currentState = stateStack.Pop();
																																																																																																																																																break;
																																																																																																																																															} else {
																																																																																																																																																if (la.kind == 195) {
																																																																																																																																																	currentState = stateStack.Pop();
																																																																																																																																																	break;
																																																																																																																																																} else {
																																																																																																																																																	if (la.kind == 196) {
																																																																																																																																																		currentState = stateStack.Pop();
																																																																																																																																																		break;
																																																																																																																																																	} else {
																																																																																																																																																		if (la.kind == 197) {
																																																																																																																																																			goto case 115;
																																																																																																																																																		} else {
																																																																																																																																																			if (la.kind == 198) {
																																																																																																																																																				currentState = stateStack.Pop();
																																																																																																																																																				break;
																																																																																																																																																			} else {
																																																																																																																																																				if (la.kind == 199) {
																																																																																																																																																					currentState = stateStack.Pop();
																																																																																																																																																					break;
																																																																																																																																																				} else {
																																																																																																																																																					if (la.kind == 200) {
																																																																																																																																																						currentState = stateStack.Pop();
																																																																																																																																																						break;
																																																																																																																																																					} else {
																																																																																																																																																						if (la.kind == 201) {
																																																																																																																																																							currentState = stateStack.Pop();
																																																																																																																																																							break;
																																																																																																																																																						} else {
																																																																																																																																																							if (la.kind == 202) {
																																																																																																																																																								currentState = stateStack.Pop();
																																																																																																																																																								break;
																																																																																																																																																							} else {
																																																																																																																																																								if (la.kind == 203) {
																																																																																																																																																									goto case 114;
																																																																																																																																																								} else {
																																																																																																																																																									if (la.kind == 204) {
																																																																																																																																																										currentState = stateStack.Pop();
																																																																																																																																																										break;
																																																																																																																																																									} else {
																																																																																																																																																										if (la.kind == 205) {
																																																																																																																																																											currentState = stateStack.Pop();
																																																																																																																																																											break;
																																																																																																																																																										} else {
																																																																																																																																																											if (la.kind == 206) {
																																																																																																																																																												goto case 113;
																																																																																																																																																											} else {
																																																																																																																																																												if (la.kind == 207) {
																																																																																																																																																													currentState = stateStack.Pop();
																																																																																																																																																													break;
																																																																																																																																																												} else {
																																																																																																																																																													if (la.kind == 208) {
																																																																																																																																																														currentState = stateStack.Pop();
																																																																																																																																																														break;
																																																																																																																																																													} else {
																																																																																																																																																														if (la.kind == 209) {
																																																																																																																																																															goto case 112;
																																																																																																																																																														} else {
																																																																																																																																																															if (la.kind == 210) {
																																																																																																																																																																goto case 111;
																																																																																																																																																															} else {
																																																																																																																																																																if (la.kind == 211) {
																																																																																																																																																																	goto case 110;
																																																																																																																																																																} else {
																																																																																																																																																																	if (la.kind == 212) {
																																																																																																																																																																		goto case 109;
																																																																																																																																																																	} else {
																																																																																																																																																																		if (la.kind == 213) {
																																																																																																																																																																			goto case 108;
																																																																																																																																																																		} else {
																																																																																																																																																																			if (la.kind == 214) {
																																																																																																																																																																				currentState = stateStack.Pop();
																																																																																																																																																																				break;
																																																																																																																																																																			} else {
																																																																																																																																																																				if (la.kind == 215) {
																																																																																																																																																																					currentState = stateStack.Pop();
																																																																																																																																																																					break;
																																																																																																																																																																				} else {
																																																																																																																																																																					if (la.kind == 216) {
																																																																																																																																																																						goto case 59;
																																																																																																																																																																					} else {
																																																																																																																																																																						if (la.kind == 217) {
																																																																																																																																																																							currentState = stateStack.Pop();
																																																																																																																																																																							break;
																																																																																																																																																																						} else {
																																																																																																																																																																							if (la.kind == 218) {
																																																																																																																																																																								goto case 107;
																																																																																																																																																																							} else {
																																																																																																																																																																								if (la.kind == 219) {
																																																																																																																																																																									currentState = stateStack.Pop();
																																																																																																																																																																									break;
																																																																																																																																																																								} else {
																																																																																																																																																																									if (la.kind == 220) {
																																																																																																																																																																										currentState = stateStack.Pop();
																																																																																																																																																																										break;
																																																																																																																																																																									} else {
																																																																																																																																																																										if (la.kind == 221) {
																																																																																																																																																																											currentState = stateStack.Pop();
																																																																																																																																																																											break;
																																																																																																																																																																										} else {
																																																																																																																																																																											if (la.kind == 222) {
																																																																																																																																																																												currentState = stateStack.Pop();
																																																																																																																																																																												break;
																																																																																																																																																																											} else {
																																																																																																																																																																												if (la.kind == 223) {
																																																																																																																																																																													goto case 106;
																																																																																																																																																																												} else {
																																																																																																																																																																													if (la.kind == 224) {
																																																																																																																																																																														goto case 105;
																																																																																																																																																																													} else {
																																																																																																																																																																														if (la.kind == 225) {
																																																																																																																																																																															currentState = stateStack.Pop();
																																																																																																																																																																															break;
																																																																																																																																																																														} else {
																																																																																																																																																																															if (la.kind == 226) {
																																																																																																																																																																																currentState = stateStack.Pop();
																																																																																																																																																																																break;
																																																																																																																																																																															} else {
																																																																																																																																																																																if (la.kind == 227) {
																																																																																																																																																																																	currentState = stateStack.Pop();
																																																																																																																																																																																	break;
																																																																																																																																																																																} else {
																																																																																																																																																																																	if (la.kind == 228) {
																																																																																																																																																																																		currentState = stateStack.Pop();
																																																																																																																																																																																		break;
																																																																																																																																																																																	} else {
																																																																																																																																																																																		if (la.kind == 229) {
																																																																																																																																																																																			currentState = stateStack.Pop();
																																																																																																																																																																																			break;
																																																																																																																																																																																		} else {
																																																																																																																																																																																			if (la.kind == 230) {
																																																																																																																																																																																				goto case 104;
																																																																																																																																																																																			} else {
																																																																																																																																																																																				if (la.kind == 231) {
																																																																																																																																																																																					goto case 103;
																																																																																																																																																																																				} else {
																																																																																																																																																																																					if (la.kind == 232) {
																																																																																																																																																																																						currentState = stateStack.Pop();
																																																																																																																																																																																						break;
																																																																																																																																																																																					} else {
																																																																																																																																																																																						if (la.kind == 233) {
																																																																																																																																																																																							goto case 102;
																																																																																																																																																																																						} else {
																																																																																																																																																																																							if (la.kind == 234) {
																																																																																																																																																																																								currentState = stateStack.Pop();
																																																																																																																																																																																								break;
																																																																																																																																																																																							} else {
																																																																																																																																																																																								if (la.kind == 235) {
																																																																																																																																																																																									currentState = stateStack.Pop();
																																																																																																																																																																																									break;
																																																																																																																																																																																								} else {
																																																																																																																																																																																									if (la.kind == 236) {
																																																																																																																																																																																										goto case 62;
																																																																																																																																																																																									} else {
																																																																																																																																																																																										if (la.kind == 237) {
																																																																																																																																																																																											currentState = stateStack.Pop();
																																																																																																																																																																																											break;
																																																																																																																																																																																										} else {
																																																																																																																																																																																											goto case 6;
																																																																																																																																																																																										}
																																																																																																																																																																																									}
																																																																																																																																																																																								}
																																																																																																																																																																																							}
																																																																																																																																																																																						}
																																																																																																																																																																																					}
																																																																																																																																																																																				}
																																																																																																																																																																																			}
																																																																																																																																																																																		}
																																																																																																																																																																																	}
																																																																																																																																																																																}
																																																																																																																																																																															}
																																																																																																																																																																														}
																																																																																																																																																																													}
																																																																																																																																																																												}
																																																																																																																																																																											}
																																																																																																																																																																										}
																																																																																																																																																																									}
																																																																																																																																																																								}
																																																																																																																																																																							}
																																																																																																																																																																						}
																																																																																																																																																																					}
																																																																																																																																																																				}
																																																																																																																																																																			}
																																																																																																																																																																		}
																																																																																																																																																																	}
																																																																																																																																																																}
																																																																																																																																																															}
																																																																																																																																																														}
																																																																																																																																																													}
																																																																																																																																																												}
																																																																																																																																																											}
																																																																																																																																																										}
																																																																																																																																																									}
																																																																																																																																																								}
																																																																																																																																																							}
																																																																																																																																																						}
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																			}
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 102: {
				if (la == null) { currentState = 102; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 103: {
				if (la == null) { currentState = 103; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 104: {
				if (la == null) { currentState = 104; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 105: {
				if (la == null) { currentState = 105; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 106: {
				if (la == null) { currentState = 106; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 107: {
				if (la == null) { currentState = 107; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 108: {
				if (la == null) { currentState = 108; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 109: {
				if (la == null) { currentState = 109; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 110: {
				if (la == null) { currentState = 110; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 111: {
				if (la == null) { currentState = 111; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 112: {
				if (la == null) { currentState = 112; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 113: {
				if (la == null) { currentState = 113; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 114: {
				if (la == null) { currentState = 114; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 115: {
				if (la == null) { currentState = 115; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 116: {
				if (la == null) { currentState = 116; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 117: {
				if (la == null) { currentState = 117; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 118: {
				if (la == null) { currentState = 118; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 119: {
				if (la == null) { currentState = 119; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 120: {
				if (la == null) { currentState = 120; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 121: {
				if (la == null) { currentState = 121; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 122: {
				if (la == null) { currentState = 122; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 123: {
				if (la == null) { currentState = 123; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 124: {
				if (la == null) { currentState = 124; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 125: {
				if (la == null) { currentState = 125; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 126: {
				if (la == null) { currentState = 126; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 127: {
				if (la == null) { currentState = 127; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 128: {
				if (la == null) { currentState = 128; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 129: {
				if (la == null) { currentState = 129; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 130: {
				if (la == null) { currentState = 130; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 131: {
				if (la == null) { currentState = 131; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 132: {
				if (la == null) { currentState = 132; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 133: {
				if (la == null) { currentState = 133; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 134: {
				if (la == null) { currentState = 134; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 135: {
				if (la == null) { currentState = 135; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 136: {
				if (la == null) { currentState = 136; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 137: {
				if (la == null) { currentState = 137; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 138: {
				if (la == null) { currentState = 138; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 139: {
				if (la == null) { currentState = 139; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 140: {
				if (la == null) { currentState = 140; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 141: {
				if (la == null) { currentState = 141; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 142: {
				if (la == null) { currentState = 142; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 143: {
				if (la == null) { currentState = 143; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 144: {
				if (la == null) { currentState = 144; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 145: {
				if (la == null) { currentState = 145; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 146: {
				if (la == null) { currentState = 146; break; }
				if (la.kind == 35 || la.kind == 126 || la.kind == 233) {
					if (la.kind == 126) {
						PushContext(Context.CollectionInitializer, la, t);
						goto case 151;
					} else {
						if (la.kind == 35) {
							PushContext(Context.CollectionInitializer, la, t);
							stateStack.Push(150);
							goto case 79;
						} else {
							if (la.kind == 233) {
								PushContext(Context.ObjectInitializer, la, t);
								goto case 147;
							} else {
								goto case 88;
							}
						}
					}
				} else {
					goto case 89;
				}
			}
			case 147: {
				if (la == null) { currentState = 147; break; }
				Expect(233, la); // "With"
				currentState = 148;
				break;
			}
			case 148: {
				stateStack.Push(149);
				goto case 93;
			}
			case 149: {
				PopContext();
				goto case 89;
			}
			case 150: {
				PopContext();
				goto case 89;
			}
			case 151: {
				if (la == null) { currentState = 151; break; }
				Expect(126, la); // "From"
				currentState = 152;
				break;
			}
			case 152: {
				if (la == null) { currentState = 152; break; }
				if (la.kind == 35) {
					stateStack.Push(153);
					goto case 79;
				} else {
					if (set[30].Get(la.kind)) {
						currentState = endOfStatementTerminatorAndBlock; /* leave this block */
							InformToken(t); /* process From again*/
							/* for processing current token (la): go to the position after processing End */
							goto switchlbl;

					} else {
						Error(la);
						goto case 153;
					}
				}
			}
			case 153: {
				PopContext();
				goto case 89;
			}
			case 154: {
				if (la == null) { currentState = 154; break; }
				currentState = 153;
				break;
			}
			case 155: {
				stateStack.Push(156);
				goto case 75;
			}
			case 156: {
				if (la == null) { currentState = 156; break; }
				Expect(144, la); // "Is"
				currentState = 157;
				break;
			}
			case 157: {
				PushContext(Context.Type, la, t);
				stateStack.Push(158);
				goto case 37;
			}
			case 158: {
				PopContext();
				goto case 78;
			}
			case 159: {
				if (la == null) { currentState = 159; break; }
				if (set[32].Get(la.kind)) {
					stateStack.Push(159);
					goto case 160;
				} else {
					goto case 78;
				}
			}
			case 160: {
				if (la == null) { currentState = 160; break; }
				if (la.kind == 37) {
					currentState = 165;
					break;
				} else {
					if (set[134].Get(la.kind)) {
						currentState = 161;
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 161: {
				nextTokenIsStartOfImportsOrAccessExpression = true;
				goto case 162;
			}
			case 162: {
				if (la == null) { currentState = 162; break; }
				if (la.kind == 10) {
					currentState = 163;
					break;
				} else {
					goto case 163;
				}
			}
			case 163: {
				stateStack.Push(164);
				goto case 101;
			}
			case 164: {
				if (la == null) { currentState = 164; break; }
				if (la.kind == 11) {
					currentState = stateStack.Pop();
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 165: {
				PushContext(Context.Expression, la, t);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 166;
			}
			case 166: {
				if (la == null) { currentState = 166; break; }
				if (la.kind == 169) {
					currentState = 168;
					break;
				} else {
					if (set[22].Get(la.kind)) {
						if (set[21].Get(la.kind)) {
							stateStack.Push(167);
							goto case 47;
						} else {
							goto case 167;
						}
					} else {
						Error(la);
						goto case 167;
					}
				}
			}
			case 167: {
				PopContext();
				goto case 46;
			}
			case 168: {
				PushContext(Context.Type, la, t);
				stateStack.Push(169);
				goto case 37;
			}
			case 169: {
				PopContext();
				goto case 170;
			}
			case 170: {
				if (la == null) { currentState = 170; break; }
				if (la.kind == 22) {
					currentState = 171;
					break;
				} else {
					goto case 167;
				}
			}
			case 171: {
				PushContext(Context.Type, la, t);
				stateStack.Push(172);
				goto case 37;
			}
			case 172: {
				PopContext();
				goto case 170;
			}
			case 173: {
				PushContext(Context.Expression, la, t);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 174;
			}
			case 174: {
				if (la == null) { currentState = 174; break; }
				if (set[135].Get(la.kind)) {
					currentState = 175;
					break;
				} else {
					if (la.kind == 37) {
						currentState = 483;
						break;
					} else {
						if (set[136].Get(la.kind)) {
							currentState = 175;
							break;
						} else {
							if (set[132].Get(la.kind)) {
								currentState = 175;
								break;
							} else {
								if (set[134].Get(la.kind)) {
									currentState = 479;
									break;
								} else {
									if (la.kind == 129) {
										currentState = 476;
										break;
									} else {
										if (la.kind == 237) {
											currentState = 473;
											break;
										} else {
											if (set[82].Get(la.kind)) {
												stateStack.Push(175);
												nextTokenIsPotentialStartOfExpression = true;
												PushContext(Context.Xml, la, t);
												goto case 456;
											} else {
												if (la.kind == 127 || la.kind == 210) {
													stateStack.Push(175);
													goto case 252;
												} else {
													if (la.kind == 58 || la.kind == 126) {
														stateStack.Push(175);
														PushContext(Context.Query, la, t);
														goto case 190;
													} else {
														if (set[37].Get(la.kind)) {
															stateStack.Push(175);
															goto case 183;
														} else {
															if (la.kind == 135) {
																stateStack.Push(175);
																goto case 176;
															} else {
																Error(la);
																goto case 175;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 175: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 176: {
				if (la == null) { currentState = 176; break; }
				Expect(135, la); // "If"
				currentState = 177;
				break;
			}
			case 177: {
				if (la == null) { currentState = 177; break; }
				Expect(37, la); // "("
				currentState = 178;
				break;
			}
			case 178: {
				stateStack.Push(179);
				goto case 55;
			}
			case 179: {
				if (la == null) { currentState = 179; break; }
				Expect(22, la); // ","
				currentState = 180;
				break;
			}
			case 180: {
				stateStack.Push(181);
				goto case 55;
			}
			case 181: {
				if (la == null) { currentState = 181; break; }
				if (la.kind == 22) {
					currentState = 182;
					break;
				} else {
					goto case 46;
				}
			}
			case 182: {
				stateStack.Push(46);
				goto case 55;
			}
			case 183: {
				if (la == null) { currentState = 183; break; }
				if (set[137].Get(la.kind)) {
					currentState = 189;
					break;
				} else {
					if (la.kind == 94 || la.kind == 106 || la.kind == 219) {
						currentState = 184;
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 184: {
				if (la == null) { currentState = 184; break; }
				Expect(37, la); // "("
				currentState = 185;
				break;
			}
			case 185: {
				stateStack.Push(186);
				goto case 55;
			}
			case 186: {
				if (la == null) { currentState = 186; break; }
				Expect(22, la); // ","
				currentState = 187;
				break;
			}
			case 187: {
				PushContext(Context.Type, la, t);
				stateStack.Push(188);
				goto case 37;
			}
			case 188: {
				PopContext();
				goto case 46;
			}
			case 189: {
				if (la == null) { currentState = 189; break; }
				Expect(37, la); // "("
				currentState = 182;
				break;
			}
			case 190: {
				if (la == null) { currentState = 190; break; }
				if (la.kind == 126) {
					stateStack.Push(191);
					goto case 251;
				} else {
					if (la.kind == 58) {
						stateStack.Push(191);
						goto case 250;
					} else {
						Error(la);
						goto case 191;
					}
				}
			}
			case 191: {
				if (la == null) { currentState = 191; break; }
				if (set[38].Get(la.kind)) {
					stateStack.Push(191);
					goto case 192;
				} else {
					PopContext();
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 192: {
				if (la == null) { currentState = 192; break; }
				if (la.kind == 126) {
					currentState = 248;
					break;
				} else {
					if (la.kind == 58) {
						currentState = 244;
						break;
					} else {
						if (la.kind == 197) {
							currentState = 242;
							break;
						} else {
							if (la.kind == 107) {
								goto case 133;
							} else {
								if (la.kind == 230) {
									currentState = 55;
									break;
								} else {
									if (la.kind == 176) {
										currentState = 238;
										break;
									} else {
										if (la.kind == 203 || la.kind == 212) {
											currentState = 236;
											break;
										} else {
											if (la.kind == 148) {
												currentState = 234;
												break;
											} else {
												if (la.kind == 133) {
													currentState = 206;
													break;
												} else {
													if (la.kind == 146) {
														currentState = 193;
														break;
													} else {
														goto case 6;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 193: {
				stateStack.Push(194);
				goto case 199;
			}
			case 194: {
				if (la == null) { currentState = 194; break; }
				Expect(171, la); // "On"
				currentState = 195;
				break;
			}
			case 195: {
				stateStack.Push(196);
				goto case 55;
			}
			case 196: {
				if (la == null) { currentState = 196; break; }
				Expect(116, la); // "Equals"
				currentState = 197;
				break;
			}
			case 197: {
				stateStack.Push(198);
				goto case 55;
			}
			case 198: {
				if (la == null) { currentState = 198; break; }
				if (la.kind == 22) {
					currentState = 195;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 199: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(200);
				goto case 205;
			}
			case 200: {
				PopContext();
				goto case 201;
			}
			case 201: {
				if (la == null) { currentState = 201; break; }
				if (la.kind == 63) {
					currentState = 203;
					break;
				} else {
					goto case 202;
				}
			}
			case 202: {
				if (la == null) { currentState = 202; break; }
				Expect(138, la); // "In"
				currentState = 55;
				break;
			}
			case 203: {
				PushContext(Context.Type, la, t);
				stateStack.Push(204);
				goto case 37;
			}
			case 204: {
				PopContext();
				goto case 202;
			}
			case 205: {
				if (la == null) { currentState = 205; break; }
				if (set[122].Get(la.kind)) {
					currentState = stateStack.Pop();
					break;
				} else {
					if (la.kind == 98) {
						goto case 135;
					} else {
						goto case 6;
					}
				}
			}
			case 206: {
				SetIdentifierExpected(la);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 207;
			}
			case 207: {
				if (la == null) { currentState = 207; break; }
				if (la.kind == 146) {
					goto case 226;
				} else {
					if (set[40].Get(la.kind)) {
						if (la.kind == 70) {
							currentState = 209;
							break;
						} else {
							if (set[40].Get(la.kind)) {
								goto case 224;
							} else {
								Error(la);
								goto case 208;
							}
						}
					} else {
						goto case 6;
					}
				}
			}
			case 208: {
				if (la == null) { currentState = 208; break; }
				Expect(70, la); // "By"
				currentState = 209;
				break;
			}
			case 209: {
				stateStack.Push(210);
				goto case 213;
			}
			case 210: {
				if (la == null) { currentState = 210; break; }
				if (la.kind == 22) {
					currentState = 209;
					break;
				} else {
					Expect(143, la); // "Into"
					currentState = 211;
					break;
				}
			}
			case 211: {
				stateStack.Push(212);
				goto case 213;
			}
			case 212: {
				if (la == null) { currentState = 212; break; }
				if (la.kind == 22) {
					currentState = 211;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 213: {
				SetIdentifierExpected(la);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 214;
			}
			case 214: {
				if (la == null) { currentState = 214; break; }
				if (set[6].Get(la.kind)) {
					PushContext(Context.Identifier, la, t);
					SetIdentifierExpected(la);
					stateStack.Push(217);
					goto case 205;
				} else {
					goto case 215;
				}
			}
			case 215: {
				stateStack.Push(216);
				goto case 55;
			}
			case 216: {
				if (!isAlreadyInExpr) PopContext(); isAlreadyInExpr = false;
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 217: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 218;
			}
			case 218: {
				if (la == null) { currentState = 218; break; }
				if (set[42].Get(la.kind)) {
					PopContext(); isAlreadyInExpr = true;
					goto case 219;
				} else {
					goto case 215;
				}
			}
			case 219: {
				if (la == null) { currentState = 219; break; }
				if (la.kind == 63) {
					currentState = 221;
					break;
				} else {
					if (la.kind == 20) {
						currentState = 215;
						break;
					} else {
						if (set[43].Get(la.kind)) {
							currentState = endOfStatementTerminatorAndBlock; /* leave this block */
								InformToken(t); /* process Identifier again*/
								/* for processing current token (la): go to the position after processing End */
								goto switchlbl;

						} else {
							Error(la);
							goto case 215;
						}
					}
				}
			}
			case 220: {
				if (la == null) { currentState = 220; break; }
				currentState = 215;
				break;
			}
			case 221: {
				PushContext(Context.Type, la, t);
				stateStack.Push(222);
				goto case 37;
			}
			case 222: {
				PopContext();
				goto case 223;
			}
			case 223: {
				if (la == null) { currentState = 223; break; }
				Expect(20, la); // "="
				currentState = 215;
				break;
			}
			case 224: {
				stateStack.Push(225);
				goto case 213;
			}
			case 225: {
				if (la == null) { currentState = 225; break; }
				if (la.kind == 22) {
					currentState = 224;
					break;
				} else {
					goto case 208;
				}
			}
			case 226: {
				stateStack.Push(227);
				goto case 233;
			}
			case 227: {
				if (la == null) { currentState = 227; break; }
				if (la.kind == 133 || la.kind == 146) {
					if (la.kind == 133) {
						currentState = 231;
						break;
					} else {
						if (la.kind == 146) {
							goto case 226;
						} else {
							Error(la);
							goto case 227;
						}
					}
				} else {
					goto case 228;
				}
			}
			case 228: {
				if (la == null) { currentState = 228; break; }
				Expect(143, la); // "Into"
				currentState = 229;
				break;
			}
			case 229: {
				stateStack.Push(230);
				goto case 213;
			}
			case 230: {
				if (la == null) { currentState = 230; break; }
				if (la.kind == 22) {
					currentState = 229;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 231: {
				stateStack.Push(232);
				goto case 233;
			}
			case 232: {
				stateStack.Push(227);
				goto case 228;
			}
			case 233: {
				if (la == null) { currentState = 233; break; }
				Expect(146, la); // "Join"
				currentState = 193;
				break;
			}
			case 234: {
				stateStack.Push(235);
				goto case 213;
			}
			case 235: {
				if (la == null) { currentState = 235; break; }
				if (la.kind == 22) {
					currentState = 234;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 236: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 237;
			}
			case 237: {
				if (la == null) { currentState = 237; break; }
				if (la.kind == 231) {
					currentState = 55;
					break;
				} else {
					goto case 55;
				}
			}
			case 238: {
				if (la == null) { currentState = 238; break; }
				Expect(70, la); // "By"
				currentState = 239;
				break;
			}
			case 239: {
				stateStack.Push(240);
				goto case 55;
			}
			case 240: {
				if (la == null) { currentState = 240; break; }
				if (la.kind == 64) {
					currentState = 241;
					break;
				} else {
					if (la.kind == 104) {
						currentState = 241;
						break;
					} else {
						Error(la);
						goto case 241;
					}
				}
			}
			case 241: {
				if (la == null) { currentState = 241; break; }
				if (la.kind == 22) {
					currentState = 239;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 242: {
				stateStack.Push(243);
				goto case 213;
			}
			case 243: {
				if (la == null) { currentState = 243; break; }
				if (la.kind == 22) {
					currentState = 242;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 244: {
				stateStack.Push(245);
				goto case 199;
			}
			case 245: {
				if (la == null) { currentState = 245; break; }
				if (set[38].Get(la.kind)) {
					stateStack.Push(245);
					goto case 192;
				} else {
					Expect(143, la); // "Into"
					currentState = 246;
					break;
				}
			}
			case 246: {
				stateStack.Push(247);
				goto case 213;
			}
			case 247: {
				if (la == null) { currentState = 247; break; }
				if (la.kind == 22) {
					currentState = 246;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 248: {
				stateStack.Push(249);
				goto case 199;
			}
			case 249: {
				if (la == null) { currentState = 249; break; }
				if (la.kind == 22) {
					currentState = 248;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 250: {
				if (la == null) { currentState = 250; break; }
				Expect(58, la); // "Aggregate"
				currentState = 244;
				break;
			}
			case 251: {
				if (la == null) { currentState = 251; break; }
				Expect(126, la); // "From"
				currentState = 248;
				break;
			}
			case 252: {
				if (la == null) { currentState = 252; break; }
				if (la.kind == 210) {
					currentState = 448;
					break;
				} else {
					if (la.kind == 127) {
						currentState = 253;
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 253: {
				if (la == null) { currentState = 253; break; }
				Expect(37, la); // "("
				currentState = 254;
				break;
			}
			case 254: {
				SetIdentifierExpected(la);
				goto case 255;
			}
			case 255: {
				if (la == null) { currentState = 255; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(256);
					goto case 427;
				} else {
					goto case 256;
				}
			}
			case 256: {
				if (la == null) { currentState = 256; break; }
				Expect(38, la); // ")"
				currentState = 257;
				break;
			}
			case 257: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 258;
			}
			case 258: {
				if (la == null) { currentState = 258; break; }
				if (set[23].Get(la.kind)) {
					goto case 55;
				} else {
					if (la.kind == 1 || la.kind == 21 || la.kind == 63) {
						if (la.kind == 63) {
							currentState = 425;
							break;
						} else {
							goto case 259;
						}
					} else {
						goto case 6;
					}
				}
			}
			case 259: {
				stateStack.Push(260);
				goto case 262;
			}
			case 260: {
				if (la == null) { currentState = 260; break; }
				Expect(113, la); // "End"
				currentState = 261;
				break;
			}
			case 261: {
				if (la == null) { currentState = 261; break; }
				Expect(127, la); // "Function"
				currentState = stateStack.Pop();
				break;
			}
			case 262: {
				PushContext(Context.Body, la, t);
				goto case 263;
			}
			case 263: {
				stateStack.Push(264);
				goto case 23;
			}
			case 264: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 265;
			}
			case 265: {
				if (la == null) { currentState = 265; break; }
				if (set[138].Get(la.kind)) {
					if (set[70].Get(la.kind)) {
						if (set[51].Get(la.kind)) {
							stateStack.Push(263);
							goto case 270;
						} else {
							goto case 263;
						}
					} else {
						if (la.kind == 113) {
							currentState = 268;
							break;
						} else {
							goto case 267;
						}
					}
				} else {
					goto case 266;
				}
			}
			case 266: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 267: {
				Error(la);
				goto case 264;
			}
			case 268: {
				if (la == null) { currentState = 268; break; }
				if (la.kind == 1 || la.kind == 21) {
					goto case 263;
				} else {
					if (set[50].Get(la.kind)) {
						currentState = endOfStatementTerminatorAndBlock; /* leave this block */
						InformToken(t); /* process End again*/
						/* for processing current token (la): go to the position after processing End */
						goto switchlbl;

					} else {
						goto case 267;
					}
				}
			}
			case 269: {
				if (la == null) { currentState = 269; break; }
				currentState = 264;
				break;
			}
			case 270: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 271;
			}
			case 271: {
				if (la == null) { currentState = 271; break; }
				if (la.kind == 88 || la.kind == 105 || la.kind == 204) {
					currentState = 402;
					break;
				} else {
					if (la.kind == 211 || la.kind == 233) {
						currentState = 398;
						break;
					} else {
						if (la.kind == 56 || la.kind == 193) {
							currentState = 396;
							break;
						} else {
							if (la.kind == 189) {
								currentState = 391;
								break;
							} else {
								if (la.kind == 135) {
									currentState = 373;
									break;
								} else {
									if (la.kind == 197) {
										currentState = 357;
										break;
									} else {
										if (la.kind == 231) {
											currentState = 353;
											break;
										} else {
											if (la.kind == 108) {
												currentState = 347;
												break;
											} else {
												if (la.kind == 124) {
													currentState = 320;
													break;
												} else {
													if (la.kind == 118 || la.kind == 171 || la.kind == 194) {
														if (la.kind == 118 || la.kind == 171) {
															if (la.kind == 171) {
																currentState = 316;
																break;
															} else {
																goto case 316;
															}
														} else {
															if (la.kind == 194) {
																currentState = 314;
																break;
															} else {
																goto case 6;
															}
														}
													} else {
														if (la.kind == 215) {
															currentState = 312;
															break;
														} else {
															if (la.kind == 218) {
																currentState = 299;
																break;
															} else {
																if (set[139].Get(la.kind)) {
																	if (la.kind == 132) {
																		currentState = 296;
																		break;
																	} else {
																		if (la.kind == 120) {
																			currentState = 295;
																			break;
																		} else {
																			if (la.kind == 89) {
																				currentState = 294;
																				break;
																			} else {
																				if (la.kind == 206) {
																					goto case 113;
																				} else {
																					if (la.kind == 195) {
																						currentState = 291;
																						break;
																					} else {
																						goto case 6;
																					}
																				}
																			}
																		}
																	}
																} else {
																	if (la.kind == 191) {
																		currentState = 289;
																		break;
																	} else {
																		if (la.kind == 117) {
																			currentState = 287;
																			break;
																		} else {
																			if (la.kind == 226) {
																				currentState = 272;
																				break;
																			} else {
																				if (set[140].Get(la.kind)) {
																					if (la.kind == 73) {
																						currentState = 55;
																						break;
																					} else {
																						goto case 55;
																					}
																				} else {
																					goto case 6;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 272: {
				stateStack.Push(273);
				SetIdentifierExpected(la);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 276;
			}
			case 273: {
				if (la == null) { currentState = 273; break; }
				if (la.kind == 22) {
					currentState = 272;
					break;
				} else {
					stateStack.Push(274);
					goto case 262;
				}
			}
			case 274: {
				if (la == null) { currentState = 274; break; }
				Expect(113, la); // "End"
				currentState = 275;
				break;
			}
			case 275: {
				if (la == null) { currentState = 275; break; }
				Expect(226, la); // "Using"
				currentState = stateStack.Pop();
				break;
			}
			case 276: {
				if (la == null) { currentState = 276; break; }
				if (set[6].Get(la.kind)) {
					PushContext(Context.Identifier, la, t);
					SetIdentifierExpected(la);
					stateStack.Push(279);
					goto case 205;
				} else {
					goto case 277;
				}
			}
			case 277: {
				stateStack.Push(278);
				goto case 55;
			}
			case 278: {
				if (!isAlreadyInExpr) PopContext(); isAlreadyInExpr = false;
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 279: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 280;
			}
			case 280: {
				if (la == null) { currentState = 280; break; }
				if (set[42].Get(la.kind)) {
					PopContext(); isAlreadyInExpr = true;
					goto case 281;
				} else {
					goto case 277;
				}
			}
			case 281: {
				if (la == null) { currentState = 281; break; }
				if (la.kind == 63) {
					currentState = 283;
					break;
				} else {
					if (la.kind == 20) {
						currentState = 277;
						break;
					} else {
						if (set[43].Get(la.kind)) {
							currentState = endOfStatementTerminatorAndBlock; /* leave this block */
								InformToken(t); /* process Identifier again*/
								/* for processing current token (la): go to the position after processing End */
								goto switchlbl;

						} else {
							Error(la);
							goto case 277;
						}
					}
				}
			}
			case 282: {
				if (la == null) { currentState = 282; break; }
				currentState = 277;
				break;
			}
			case 283: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 284;
			}
			case 284: {
				if (la == null) { currentState = 284; break; }
				if (set[16].Get(la.kind)) {
					PushContext(Context.Type, la, t);
					stateStack.Push(285);
					goto case 37;
				} else {
					goto case 277;
				}
			}
			case 285: {
				PopContext();
				goto case 286;
			}
			case 286: {
				if (la == null) { currentState = 286; break; }
				Expect(20, la); // "="
				currentState = 277;
				break;
			}
			case 287: {
				stateStack.Push(288);
				goto case 55;
			}
			case 288: {
				if (la == null) { currentState = 288; break; }
				if (la.kind == 22) {
					currentState = 287;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 289: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 290;
			}
			case 290: {
				if (la == null) { currentState = 290; break; }
				if (la.kind == 184) {
					currentState = 55;
					break;
				} else {
					goto case 55;
				}
			}
			case 291: {
				PushContext(Context.Expression, la, t);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 292;
			}
			case 292: {
				if (la == null) { currentState = 292; break; }
				if (set[23].Get(la.kind)) {
					stateStack.Push(293);
					goto case 55;
				} else {
					goto case 293;
				}
			}
			case 293: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 294: {
				if (la == null) { currentState = 294; break; }
				if (la.kind == 108) {
					goto case 132;
				} else {
					if (la.kind == 124) {
						goto case 129;
					} else {
						if (la.kind == 231) {
							goto case 103;
						} else {
							goto case 6;
						}
					}
				}
			}
			case 295: {
				if (la == null) { currentState = 295; break; }
				if (la.kind == 108) {
					goto case 132;
				} else {
					if (la.kind == 124) {
						goto case 129;
					} else {
						if (la.kind == 231) {
							goto case 103;
						} else {
							if (la.kind == 197) {
								goto case 115;
							} else {
								if (la.kind == 210) {
									goto case 111;
								} else {
									if (la.kind == 127) {
										goto case 127;
									} else {
										if (la.kind == 186) {
											goto case 116;
										} else {
											if (la.kind == 218) {
												goto case 107;
											} else {
												goto case 6;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 296: {
				if (la == null) { currentState = 296; break; }
				if (set[6].Get(la.kind)) {
					goto case 298;
				} else {
					if (la.kind == 5) {
						goto case 297;
					} else {
						goto case 6;
					}
				}
			}
			case 297: {
				if (la == null) { currentState = 297; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 298: {
				if (la == null) { currentState = 298; break; }
				currentState = stateStack.Pop();
				break;
			}
			case 299: {
				stateStack.Push(300);
				goto case 262;
			}
			case 300: {
				if (la == null) { currentState = 300; break; }
				if (la.kind == 75) {
					currentState = 304;
					break;
				} else {
					if (la.kind == 123) {
						currentState = 303;
						break;
					} else {
						goto case 301;
					}
				}
			}
			case 301: {
				if (la == null) { currentState = 301; break; }
				Expect(113, la); // "End"
				currentState = 302;
				break;
			}
			case 302: {
				if (la == null) { currentState = 302; break; }
				Expect(218, la); // "Try"
				currentState = stateStack.Pop();
				break;
			}
			case 303: {
				stateStack.Push(301);
				goto case 262;
			}
			case 304: {
				SetIdentifierExpected(la);
				goto case 305;
			}
			case 305: {
				if (la == null) { currentState = 305; break; }
				if (set[6].Get(la.kind)) {
					PushContext(Context.Identifier, la, t);
					SetIdentifierExpected(la);
					stateStack.Push(308);
					goto case 205;
				} else {
					goto case 306;
				}
			}
			case 306: {
				if (la == null) { currentState = 306; break; }
				if (la.kind == 229) {
					currentState = 307;
					break;
				} else {
					goto case 299;
				}
			}
			case 307: {
				stateStack.Push(299);
				goto case 55;
			}
			case 308: {
				PopContext();
				goto case 309;
			}
			case 309: {
				if (la == null) { currentState = 309; break; }
				if (la.kind == 63) {
					currentState = 310;
					break;
				} else {
					goto case 306;
				}
			}
			case 310: {
				PushContext(Context.Type, la, t);
				stateStack.Push(311);
				goto case 37;
			}
			case 311: {
				PopContext();
				goto case 306;
			}
			case 312: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 313;
			}
			case 313: {
				if (la == null) { currentState = 313; break; }
				if (set[23].Get(la.kind)) {
					goto case 55;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 314: {
				if (la == null) { currentState = 314; break; }
				if (la.kind == 163) {
					goto case 120;
				} else {
					goto case 315;
				}
			}
			case 315: {
				if (la == null) { currentState = 315; break; }
				if (la.kind == 5) {
					goto case 297;
				} else {
					if (set[6].Get(la.kind)) {
						goto case 298;
					} else {
						goto case 6;
					}
				}
			}
			case 316: {
				if (la == null) { currentState = 316; break; }
				Expect(118, la); // "Error"
				currentState = 317;
				break;
			}
			case 317: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 318;
			}
			case 318: {
				if (la == null) { currentState = 318; break; }
				if (set[23].Get(la.kind)) {
					goto case 55;
				} else {
					if (la.kind == 132) {
						currentState = 315;
						break;
					} else {
						if (la.kind == 194) {
							currentState = 319;
							break;
						} else {
							goto case 6;
						}
					}
				}
			}
			case 319: {
				if (la == null) { currentState = 319; break; }
				Expect(163, la); // "Next"
				currentState = stateStack.Pop();
				break;
			}
			case 320: {
				nextTokenIsPotentialStartOfExpression = true;
				SetIdentifierExpected(la);
				goto case 321;
			}
			case 321: {
				if (la == null) { currentState = 321; break; }
				if (set[35].Get(la.kind)) {
					stateStack.Push(337);
					goto case 331;
				} else {
					if (la.kind == 110) {
						currentState = 322;
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 322: {
				stateStack.Push(323);
				goto case 331;
			}
			case 323: {
				if (la == null) { currentState = 323; break; }
				Expect(138, la); // "In"
				currentState = 324;
				break;
			}
			case 324: {
				stateStack.Push(325);
				goto case 55;
			}
			case 325: {
				stateStack.Push(326);
				goto case 262;
			}
			case 326: {
				if (la == null) { currentState = 326; break; }
				Expect(163, la); // "Next"
				currentState = 327;
				break;
			}
			case 327: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 328;
			}
			case 328: {
				if (la == null) { currentState = 328; break; }
				if (set[23].Get(la.kind)) {
					goto case 329;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 329: {
				stateStack.Push(330);
				goto case 55;
			}
			case 330: {
				if (la == null) { currentState = 330; break; }
				if (la.kind == 22) {
					currentState = 329;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 331: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(332);
				goto case 173;
			}
			case 332: {
				PopContext();
				goto case 333;
			}
			case 333: {
				if (la == null) { currentState = 333; break; }
				if (la.kind == 33) {
					currentState = 334;
					break;
				} else {
					goto case 334;
				}
			}
			case 334: {
				if (la == null) { currentState = 334; break; }
				if (set[32].Get(la.kind)) {
					stateStack.Push(334);
					goto case 160;
				} else {
					if (la.kind == 63) {
						currentState = 335;
						break;
					} else {
						currentState = stateStack.Pop();
						goto switchlbl;
					}
				}
			}
			case 335: {
				PushContext(Context.Type, la, t);
				stateStack.Push(336);
				goto case 37;
			}
			case 336: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 337: {
				if (la == null) { currentState = 337; break; }
				Expect(20, la); // "="
				currentState = 338;
				break;
			}
			case 338: {
				stateStack.Push(339);
				goto case 55;
			}
			case 339: {
				if (la == null) { currentState = 339; break; }
				if (la.kind == 205) {
					currentState = 346;
					break;
				} else {
					goto case 340;
				}
			}
			case 340: {
				stateStack.Push(341);
				goto case 262;
			}
			case 341: {
				if (la == null) { currentState = 341; break; }
				Expect(163, la); // "Next"
				currentState = 342;
				break;
			}
			case 342: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 343;
			}
			case 343: {
				if (la == null) { currentState = 343; break; }
				if (set[23].Get(la.kind)) {
					goto case 344;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 344: {
				stateStack.Push(345);
				goto case 55;
			}
			case 345: {
				if (la == null) { currentState = 345; break; }
				if (la.kind == 22) {
					currentState = 344;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 346: {
				stateStack.Push(340);
				goto case 55;
			}
			case 347: {
				if (la == null) { currentState = 347; break; }
				if (la.kind == 224 || la.kind == 231) {
					currentState = 350;
					break;
				} else {
					if (la.kind == 1 || la.kind == 21) {
						stateStack.Push(348);
						goto case 262;
					} else {
						goto case 6;
					}
				}
			}
			case 348: {
				if (la == null) { currentState = 348; break; }
				Expect(152, la); // "Loop"
				currentState = 349;
				break;
			}
			case 349: {
				if (la == null) { currentState = 349; break; }
				if (la.kind == 224 || la.kind == 231) {
					currentState = 55;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 350: {
				stateStack.Push(351);
				goto case 55;
			}
			case 351: {
				stateStack.Push(352);
				goto case 262;
			}
			case 352: {
				if (la == null) { currentState = 352; break; }
				Expect(152, la); // "Loop"
				currentState = stateStack.Pop();
				break;
			}
			case 353: {
				stateStack.Push(354);
				goto case 55;
			}
			case 354: {
				stateStack.Push(355);
				goto case 262;
			}
			case 355: {
				if (la == null) { currentState = 355; break; }
				Expect(113, la); // "End"
				currentState = 356;
				break;
			}
			case 356: {
				if (la == null) { currentState = 356; break; }
				Expect(231, la); // "While"
				currentState = stateStack.Pop();
				break;
			}
			case 357: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 358;
			}
			case 358: {
				if (la == null) { currentState = 358; break; }
				if (la.kind == 74) {
					currentState = 359;
					break;
				} else {
					goto case 359;
				}
			}
			case 359: {
				stateStack.Push(360);
				goto case 55;
			}
			case 360: {
				stateStack.Push(361);
				goto case 23;
			}
			case 361: {
				if (la == null) { currentState = 361; break; }
				if (la.kind == 74) {
					currentState = 363;
					break;
				} else {
					Expect(113, la); // "End"
					currentState = 362;
					break;
				}
			}
			case 362: {
				if (la == null) { currentState = 362; break; }
				Expect(197, la); // "Select"
				currentState = stateStack.Pop();
				break;
			}
			case 363: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 364;
			}
			case 364: {
				if (la == null) { currentState = 364; break; }
				if (la.kind == 111) {
					currentState = 365;
					break;
				} else {
					if (set[68].Get(la.kind)) {
						goto case 366;
					} else {
						Error(la);
						goto case 365;
					}
				}
			}
			case 365: {
				stateStack.Push(361);
				goto case 262;
			}
			case 366: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 367;
			}
			case 367: {
				if (la == null) { currentState = 367; break; }
				if (set[141].Get(la.kind)) {
					if (la.kind == 144) {
						currentState = 369;
						break;
					} else {
						goto case 369;
					}
				} else {
					if (set[23].Get(la.kind)) {
						stateStack.Push(368);
						goto case 55;
					} else {
						Error(la);
						goto case 368;
					}
				}
			}
			case 368: {
				if (la == null) { currentState = 368; break; }
				if (la.kind == 22) {
					currentState = 366;
					break;
				} else {
					goto case 365;
				}
			}
			case 369: {
				stateStack.Push(370);
				goto case 371;
			}
			case 370: {
				stateStack.Push(368);
				goto case 75;
			}
			case 371: {
				if (la == null) { currentState = 371; break; }
				if (la.kind == 20) {
					goto case 73;
				} else {
					if (la.kind == 41) {
						goto case 72;
					} else {
						if (la.kind == 40) {
							goto case 71;
						} else {
							if (la.kind == 39) {
								currentState = 372;
								break;
							} else {
								if (la.kind == 42) {
									goto case 68;
								} else {
									if (la.kind == 43) {
										goto case 69;
									} else {
										goto case 6;
									}
								}
							}
						}
					}
				}
			}
			case 372: {
				wasNormalAttribute = false;
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 373: {
				stateStack.Push(374);
				goto case 55;
			}
			case 374: {
				if (la == null) { currentState = 374; break; }
				if (la.kind == 214) {
					currentState = 382;
					break;
				} else {
					goto case 375;
				}
			}
			case 375: {
				if (la == null) { currentState = 375; break; }
				if (la.kind == 1 || la.kind == 21) {
					goto case 376;
				} else {
					goto case 6;
				}
			}
			case 376: {
				stateStack.Push(377);
				goto case 262;
			}
			case 377: {
				if (la == null) { currentState = 377; break; }
				if (la.kind == 111 || la.kind == 112) {
					if (la.kind == 111) {
						currentState = 381;
						break;
					} else {
						if (la.kind == 112) {
							currentState = 379;
							break;
						} else {
							Error(la);
							goto case 376;
						}
					}
				} else {
					Expect(113, la); // "End"
					currentState = 378;
					break;
				}
			}
			case 378: {
				if (la == null) { currentState = 378; break; }
				Expect(135, la); // "If"
				currentState = stateStack.Pop();
				break;
			}
			case 379: {
				stateStack.Push(380);
				goto case 55;
			}
			case 380: {
				if (la == null) { currentState = 380; break; }
				if (la.kind == 214) {
					currentState = 376;
					break;
				} else {
					goto case 376;
				}
			}
			case 381: {
				if (la == null) { currentState = 381; break; }
				if (la.kind == 135) {
					currentState = 379;
					break;
				} else {
					goto case 376;
				}
			}
			case 382: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 383;
			}
			case 383: {
				if (la == null) { currentState = 383; break; }
				if (set[51].Get(la.kind)) {
					goto case 384;
				} else {
					goto case 375;
				}
			}
			case 384: {
				stateStack.Push(385);
				goto case 270;
			}
			case 385: {
				if (la == null) { currentState = 385; break; }
				if (la.kind == 21) {
					currentState = 389;
					break;
				} else {
					if (la.kind == 111) {
						currentState = 386;
						break;
					} else {
						currentState = stateStack.Pop();
						goto switchlbl;
					}
				}
			}
			case 386: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 387;
			}
			case 387: {
				if (la == null) { currentState = 387; break; }
				if (set[51].Get(la.kind)) {
					stateStack.Push(388);
					goto case 270;
				} else {
					goto case 388;
				}
			}
			case 388: {
				if (la == null) { currentState = 388; break; }
				if (la.kind == 21) {
					currentState = 386;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 389: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 390;
			}
			case 390: {
				if (la == null) { currentState = 390; break; }
				if (set[51].Get(la.kind)) {
					goto case 384;
				} else {
					goto case 385;
				}
			}
			case 391: {
				stateStack.Push(392);
				goto case 101;
			}
			case 392: {
				if (la == null) { currentState = 392; break; }
				if (la.kind == 37) {
					currentState = 393;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 393: {
				PushContext(Context.Expression, la, t);
				nextTokenIsPotentialStartOfExpression = true;
				goto case 394;
			}
			case 394: {
				if (la == null) { currentState = 394; break; }
				if (set[21].Get(la.kind)) {
					stateStack.Push(395);
					goto case 47;
				} else {
					goto case 395;
				}
			}
			case 395: {
				PopContext();
				goto case 46;
			}
			case 396: {
				stateStack.Push(397);
				goto case 55;
			}
			case 397: {
				if (la == null) { currentState = 397; break; }
				Expect(22, la); // ","
				currentState = 55;
				break;
			}
			case 398: {
				stateStack.Push(399);
				goto case 55;
			}
			case 399: {
				stateStack.Push(400);
				goto case 262;
			}
			case 400: {
				if (la == null) { currentState = 400; break; }
				Expect(113, la); // "End"
				currentState = 401;
				break;
			}
			case 401: {
				if (la == null) { currentState = 401; break; }
				if (la.kind == 233) {
					goto case 102;
				} else {
					if (la.kind == 211) {
						goto case 110;
					} else {
						goto case 6;
					}
				}
			}
			case 402: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(403);
				goto case 205;
			}
			case 403: {
				PopContext();
				goto case 404;
			}
			case 404: {
				if (la == null) { currentState = 404; break; }
				if (la.kind == 33) {
					currentState = 405;
					break;
				} else {
					goto case 405;
				}
			}
			case 405: {
				if (la == null) { currentState = 405; break; }
				if (la.kind == 37) {
					currentState = 422;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 419;
						break;
					} else {
						goto case 406;
					}
				}
			}
			case 406: {
				if (la == null) { currentState = 406; break; }
				if (la.kind == 20) {
					currentState = 418;
					break;
				} else {
					goto case 407;
				}
			}
			case 407: {
				if (la == null) { currentState = 407; break; }
				if (la.kind == 22) {
					currentState = 408;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 408: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(409);
				goto case 205;
			}
			case 409: {
				PopContext();
				goto case 410;
			}
			case 410: {
				if (la == null) { currentState = 410; break; }
				if (la.kind == 33) {
					currentState = 411;
					break;
				} else {
					goto case 411;
				}
			}
			case 411: {
				if (la == null) { currentState = 411; break; }
				if (la.kind == 37) {
					currentState = 415;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 412;
						break;
					} else {
						goto case 406;
					}
				}
			}
			case 412: {
				PushContext(Context.Type, la, t);
				goto case 413;
			}
			case 413: {
				if (la == null) { currentState = 413; break; }
				if (la.kind == 162) {
					stateStack.Push(414);
					goto case 85;
				} else {
					if (set[16].Get(la.kind)) {
						stateStack.Push(414);
						goto case 37;
					} else {
						Error(la);
						goto case 414;
					}
				}
			}
			case 414: {
				PopContext();
				goto case 406;
			}
			case 415: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 416;
			}
			case 416: {
				if (la == null) { currentState = 416; break; }
				if (set[23].Get(la.kind)) {
					stateStack.Push(417);
					goto case 55;
				} else {
					goto case 417;
				}
			}
			case 417: {
				if (la == null) { currentState = 417; break; }
				if (la.kind == 22) {
					currentState = 415;
					break;
				} else {
					Expect(38, la); // ")"
					currentState = 411;
					break;
				}
			}
			case 418: {
				stateStack.Push(407);
				goto case 55;
			}
			case 419: {
				PushContext(Context.Type, la, t);
				goto case 420;
			}
			case 420: {
				if (la == null) { currentState = 420; break; }
				if (la.kind == 162) {
					stateStack.Push(421);
					goto case 85;
				} else {
					if (set[16].Get(la.kind)) {
						stateStack.Push(421);
						goto case 37;
					} else {
						Error(la);
						goto case 421;
					}
				}
			}
			case 421: {
				PopContext();
				goto case 406;
			}
			case 422: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 423;
			}
			case 423: {
				if (la == null) { currentState = 423; break; }
				if (set[23].Get(la.kind)) {
					stateStack.Push(424);
					goto case 55;
				} else {
					goto case 424;
				}
			}
			case 424: {
				if (la == null) { currentState = 424; break; }
				if (la.kind == 22) {
					currentState = 422;
					break;
				} else {
					Expect(38, la); // ")"
					currentState = 405;
					break;
				}
			}
			case 425: {
				PushContext(Context.Type, la, t);
				stateStack.Push(426);
				goto case 37;
			}
			case 426: {
				PopContext();
				goto case 259;
			}
			case 427: {
				stateStack.Push(428);
				PushContext(Context.Parameter, la, t);
				goto case 429;
			}
			case 428: {
				if (la == null) { currentState = 428; break; }
				if (la.kind == 22) {
					currentState = 427;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 429: {
				SetIdentifierExpected(la);
				goto case 430;
			}
			case 430: {
				if (la == null) { currentState = 430; break; }
				if (la.kind == 40) {
					stateStack.Push(429);
					goto case 440;
				} else {
					goto case 431;
				}
			}
			case 431: {
				SetIdentifierExpected(la);
				goto case 432;
			}
			case 432: {
				if (la == null) { currentState = 432; break; }
				if (set[142].Get(la.kind)) {
					currentState = 431;
					break;
				} else {
					PushContext(Context.Identifier, la, t);
					SetIdentifierExpected(la);
					stateStack.Push(433);
					goto case 205;
				}
			}
			case 433: {
				PopContext();
				goto case 434;
			}
			case 434: {
				if (la == null) { currentState = 434; break; }
				if (la.kind == 63) {
					currentState = 438;
					break;
				} else {
					goto case 435;
				}
			}
			case 435: {
				if (la == null) { currentState = 435; break; }
				if (la.kind == 20) {
					currentState = 437;
					break;
				} else {
					goto case 436;
				}
			}
			case 436: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 437: {
				stateStack.Push(436);
				goto case 55;
			}
			case 438: {
				PushContext(Context.Type, la, t);
				stateStack.Push(439);
				goto case 37;
			}
			case 439: {
				PopContext();
				goto case 435;
			}
			case 440: {
				if (la == null) { currentState = 440; break; }
				Expect(40, la); // "<"
				currentState = 441;
				break;
			}
			case 441: {
				wasNormalAttribute = true; PushContext(Context.Attribute, la, t);
				goto case 442;
			}
			case 442: {
				if (la == null) { currentState = 442; break; }
				if (la.kind == 65 || la.kind == 155) {
					currentState = 446;
					break;
				} else {
					goto case 443;
				}
			}
			case 443: {
				if (la == null) { currentState = 443; break; }
				if (set[143].Get(la.kind)) {
					currentState = 443;
					break;
				} else {
					Expect(39, la); // ">"
					currentState = 444;
					break;
				}
			}
			case 444: {
				PopContext();
				goto case 445;
			}
			case 445: {
				if (la == null) { currentState = 445; break; }
				if (la.kind == 1) {
					goto case 25;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 446: {
				if (la == null) { currentState = 446; break; }
				Expect(21, la); // ":"
				currentState = 447;
				break;
			}
			case 447: {
				wasNormalAttribute = false;
				goto case 443;
			}
			case 448: {
				if (la == null) { currentState = 448; break; }
				Expect(37, la); // "("
				currentState = 449;
				break;
			}
			case 449: {
				SetIdentifierExpected(la);
				goto case 450;
			}
			case 450: {
				if (la == null) { currentState = 450; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(451);
					goto case 427;
				} else {
					goto case 451;
				}
			}
			case 451: {
				if (la == null) { currentState = 451; break; }
				Expect(38, la); // ")"
				currentState = 452;
				break;
			}
			case 452: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 453;
			}
			case 453: {
				if (la == null) { currentState = 453; break; }
				if (set[51].Get(la.kind)) {
					goto case 270;
				} else {
					if (la.kind == 1 || la.kind == 21) {
						stateStack.Push(454);
						goto case 262;
					} else {
						goto case 6;
					}
				}
			}
			case 454: {
				if (la == null) { currentState = 454; break; }
				Expect(113, la); // "End"
				currentState = 455;
				break;
			}
			case 455: {
				if (la == null) { currentState = 455; break; }
				Expect(210, la); // "Sub"
				currentState = stateStack.Pop();
				break;
			}
			case 456: {
				if (la == null) { currentState = 456; break; }
				if (la.kind == 17 || la.kind == 18 || la.kind == 19) {
					currentState = 469;
					break;
				} else {
					if (la.kind == 10) {
						stateStack.Push(458);
						goto case 460;
					} else {
						Error(la);
						goto case 457;
					}
				}
			}
			case 457: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 458: {
				if (la == null) { currentState = 458; break; }
				if (la.kind == 17) {
					currentState = 459;
					break;
				} else {
					goto case 457;
				}
			}
			case 459: {
				if (la == null) { currentState = 459; break; }
				if (la.kind == 16) {
					currentState = 458;
					break;
				} else {
					goto case 458;
				}
			}
			case 460: {
				PushContext(Context.Xml, la, t);
				goto case 461;
			}
			case 461: {
				if (la == null) { currentState = 461; break; }
				Expect(10, la); // XmlOpenTag
				currentState = 462;
				break;
			}
			case 462: {
				if (la == null) { currentState = 462; break; }
				if (set[144].Get(la.kind)) {
					if (set[145].Get(la.kind)) {
						currentState = 462;
						break;
					} else {
						if (la.kind == 12) {
							stateStack.Push(462);
							goto case 466;
						} else {
							Error(la);
							goto case 462;
						}
					}
				} else {
					if (la.kind == 14) {
						currentState = 463;
						break;
					} else {
						if (la.kind == 11) {
							currentState = 464;
							break;
						} else {
							Error(la);
							goto case 463;
						}
					}
				}
			}
			case 463: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 464: {
				if (la == null) { currentState = 464; break; }
				if (set[146].Get(la.kind)) {
					if (set[147].Get(la.kind)) {
						currentState = 464;
						break;
					} else {
						if (la.kind == 12) {
							stateStack.Push(464);
							goto case 466;
						} else {
							if (la.kind == 10) {
								stateStack.Push(464);
								goto case 460;
							} else {
								Error(la);
								goto case 464;
							}
						}
					}
				} else {
					Expect(15, la); // XmlOpenEndTag
					currentState = 465;
					break;
				}
			}
			case 465: {
				if (la == null) { currentState = 465; break; }
				if (set[148].Get(la.kind)) {
					if (set[149].Get(la.kind)) {
						currentState = 465;
						break;
					} else {
						if (la.kind == 12) {
							stateStack.Push(465);
							goto case 466;
						} else {
							Error(la);
							goto case 465;
						}
					}
				} else {
					Expect(11, la); // XmlCloseTag
					currentState = 463;
					break;
				}
			}
			case 466: {
				if (la == null) { currentState = 466; break; }
				Expect(12, la); // XmlStartInlineVB
				currentState = 467;
				break;
			}
			case 467: {
				stateStack.Push(468);
				goto case 55;
			}
			case 468: {
				if (la == null) { currentState = 468; break; }
				Expect(13, la); // XmlEndInlineVB
				currentState = stateStack.Pop();
				break;
			}
			case 469: {
				if (la == null) { currentState = 469; break; }
				if (la.kind == 16) {
					currentState = 470;
					break;
				} else {
					goto case 470;
				}
			}
			case 470: {
				if (la == null) { currentState = 470; break; }
				if (la.kind == 17 || la.kind == 19) {
					currentState = 469;
					break;
				} else {
					if (la.kind == 10) {
						stateStack.Push(471);
						goto case 460;
					} else {
						goto case 457;
					}
				}
			}
			case 471: {
				if (la == null) { currentState = 471; break; }
				if (la.kind == 17) {
					currentState = 472;
					break;
				} else {
					goto case 457;
				}
			}
			case 472: {
				if (la == null) { currentState = 472; break; }
				if (la.kind == 16) {
					currentState = 471;
					break;
				} else {
					goto case 471;
				}
			}
			case 473: {
				if (la == null) { currentState = 473; break; }
				Expect(37, la); // "("
				currentState = 474;
				break;
			}
			case 474: {
				readXmlIdentifier = true;
				stateStack.Push(475);
				goto case 205;
			}
			case 475: {
				if (la == null) { currentState = 475; break; }
				Expect(38, la); // ")"
				currentState = 175;
				break;
			}
			case 476: {
				if (la == null) { currentState = 476; break; }
				Expect(37, la); // "("
				currentState = 477;
				break;
			}
			case 477: {
				PushContext(Context.Type, la, t);
				stateStack.Push(478);
				goto case 37;
			}
			case 478: {
				PopContext();
				goto case 475;
			}
			case 479: {
				nextTokenIsStartOfImportsOrAccessExpression = true; wasQualifierTokenAtStart = true;
				goto case 480;
			}
			case 480: {
				if (la == null) { currentState = 480; break; }
				if (la.kind == 10) {
					currentState = 481;
					break;
				} else {
					goto case 481;
				}
			}
			case 481: {
				stateStack.Push(482);
				goto case 101;
			}
			case 482: {
				if (la == null) { currentState = 482; break; }
				if (la.kind == 11) {
					currentState = 175;
					break;
				} else {
					goto case 175;
				}
			}
			case 483: {
				activeArgument = 0;
				goto case 484;
			}
			case 484: {
				stateStack.Push(485);
				goto case 55;
			}
			case 485: {
				if (la == null) { currentState = 485; break; }
				if (la.kind == 22) {
					currentState = 486;
					break;
				} else {
					goto case 475;
				}
			}
			case 486: {
				activeArgument++;
				goto case 484;
			}
			case 487: {
				stateStack.Push(488);
				goto case 55;
			}
			case 488: {
				if (la == null) { currentState = 488; break; }
				if (la.kind == 22) {
					currentState = 489;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 489: {
				activeArgument++;
				nextTokenIsPotentialStartOfExpression = true;
				goto case 490;
			}
			case 490: {
				if (la == null) { currentState = 490; break; }
				if (set[23].Get(la.kind)) {
					goto case 487;
				} else {
					goto case 488;
				}
			}
			case 491: {
				if (la == null) { currentState = 491; break; }
				if (set[16].Get(la.kind)) {
					PushContext(Context.Type, la, t);
					stateStack.Push(495);
					goto case 37;
				} else {
					goto case 492;
				}
			}
			case 492: {
				if (la == null) { currentState = 492; break; }
				if (la.kind == 22) {
					currentState = 493;
					break;
				} else {
					goto case 45;
				}
			}
			case 493: {
				if (la == null) { currentState = 493; break; }
				if (set[16].Get(la.kind)) {
					PushContext(Context.Type, la, t);
					stateStack.Push(494);
					goto case 37;
				} else {
					goto case 492;
				}
			}
			case 494: {
				PopContext();
				goto case 492;
			}
			case 495: {
				PopContext();
				goto case 492;
			}
			case 496: {
				SetIdentifierExpected(la);
				goto case 497;
			}
			case 497: {
				if (la == null) { currentState = 497; break; }
				if (set[150].Get(la.kind)) {
					if (la.kind == 169) {
						currentState = 499;
						break;
					} else {
						if (set[77].Get(la.kind)) {
							stateStack.Push(498);
							goto case 427;
						} else {
							Error(la);
							goto case 498;
						}
					}
				} else {
					goto case 498;
				}
			}
			case 498: {
				if (la == null) { currentState = 498; break; }
				Expect(38, la); // ")"
				currentState = 34;
				break;
			}
			case 499: {
				stateStack.Push(498);
				goto case 500;
			}
			case 500: {
				SetIdentifierExpected(la);
				goto case 501;
			}
			case 501: {
				if (la == null) { currentState = 501; break; }
				if (la.kind == 138 || la.kind == 178) {
					currentState = 502;
					break;
				} else {
					goto case 502;
				}
			}
			case 502: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(503);
				goto case 517;
			}
			case 503: {
				PopContext();
				goto case 504;
			}
			case 504: {
				if (la == null) { currentState = 504; break; }
				if (la.kind == 63) {
					currentState = 518;
					break;
				} else {
					goto case 505;
				}
			}
			case 505: {
				if (la == null) { currentState = 505; break; }
				if (la.kind == 22) {
					currentState = 506;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 506: {
				SetIdentifierExpected(la);
				goto case 507;
			}
			case 507: {
				if (la == null) { currentState = 507; break; }
				if (la.kind == 138 || la.kind == 178) {
					currentState = 508;
					break;
				} else {
					goto case 508;
				}
			}
			case 508: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(509);
				goto case 517;
			}
			case 509: {
				PopContext();
				goto case 510;
			}
			case 510: {
				if (la == null) { currentState = 510; break; }
				if (la.kind == 63) {
					currentState = 511;
					break;
				} else {
					goto case 505;
				}
			}
			case 511: {
				PushContext(Context.Type, la, t);
				stateStack.Push(512);
				goto case 513;
			}
			case 512: {
				PopContext();
				goto case 505;
			}
			case 513: {
				if (la == null) { currentState = 513; break; }
				if (set[93].Get(la.kind)) {
					goto case 516;
				} else {
					if (la.kind == 35) {
						currentState = 514;
						break;
					} else {
						goto case 6;
					}
				}
			}
			case 514: {
				stateStack.Push(515);
				goto case 516;
			}
			case 515: {
				if (la == null) { currentState = 515; break; }
				if (la.kind == 22) {
					currentState = 514;
					break;
				} else {
					goto case 82;
				}
			}
			case 516: {
				if (la == null) { currentState = 516; break; }
				if (set[16].Get(la.kind)) {
					currentState = 38;
					break;
				} else {
					if (la.kind == 162) {
						goto case 121;
					} else {
						if (la.kind == 84) {
							goto case 137;
						} else {
							if (la.kind == 209) {
								goto case 112;
							} else {
								goto case 6;
							}
						}
					}
				}
			}
			case 517: {
				if (la == null) { currentState = 517; break; }
				if (la.kind == 2) {
					goto case 145;
				} else {
					if (la.kind == 62) {
						goto case 143;
					} else {
						if (la.kind == 64) {
							goto case 142;
						} else {
							if (la.kind == 65) {
								goto case 141;
							} else {
								if (la.kind == 66) {
									goto case 140;
								} else {
									if (la.kind == 67) {
										goto case 139;
									} else {
										if (la.kind == 70) {
											goto case 138;
										} else {
											if (la.kind == 87) {
												goto case 136;
											} else {
												if (la.kind == 104) {
													goto case 134;
												} else {
													if (la.kind == 107) {
														goto case 133;
													} else {
														if (la.kind == 116) {
															goto case 131;
														} else {
															if (la.kind == 121) {
																goto case 130;
															} else {
																if (la.kind == 133) {
																	goto case 126;
																} else {
																	if (la.kind == 139) {
																		goto case 125;
																	} else {
																		if (la.kind == 143) {
																			goto case 124;
																		} else {
																			if (la.kind == 146) {
																				goto case 123;
																			} else {
																				if (la.kind == 147) {
																					goto case 122;
																				} else {
																					if (la.kind == 170) {
																						goto case 119;
																					} else {
																						if (la.kind == 176) {
																							goto case 118;
																						} else {
																							if (la.kind == 184) {
																								goto case 117;
																							} else {
																								if (la.kind == 203) {
																									goto case 114;
																								} else {
																									if (la.kind == 212) {
																										goto case 109;
																									} else {
																										if (la.kind == 213) {
																											goto case 108;
																										} else {
																											if (la.kind == 223) {
																												goto case 106;
																											} else {
																												if (la.kind == 224) {
																													goto case 105;
																												} else {
																													if (la.kind == 230) {
																														goto case 104;
																													} else {
																														goto case 6;
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			case 518: {
				PushContext(Context.Type, la, t);
				stateStack.Push(519);
				goto case 513;
			}
			case 519: {
				PopContext();
				goto case 505;
			}
			case 520: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(521);
				goto case 205;
			}
			case 521: {
				PopContext();
				goto case 522;
			}
			case 522: {
				if (la == null) { currentState = 522; break; }
				if (la.kind == 37) {
					currentState = 527;
					break;
				} else {
					goto case 523;
				}
			}
			case 523: {
				if (la == null) { currentState = 523; break; }
				if (la.kind == 63) {
					currentState = 524;
					break;
				} else {
					goto case 23;
				}
			}
			case 524: {
				PushContext(Context.Type, la, t);
				goto case 525;
			}
			case 525: {
				if (la == null) { currentState = 525; break; }
				if (la.kind == 40) {
					stateStack.Push(525);
					goto case 440;
				} else {
					stateStack.Push(526);
					goto case 37;
				}
			}
			case 526: {
				PopContext();
				goto case 23;
			}
			case 527: {
				SetIdentifierExpected(la);
				goto case 528;
			}
			case 528: {
				if (la == null) { currentState = 528; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(529);
					goto case 427;
				} else {
					goto case 529;
				}
			}
			case 529: {
				if (la == null) { currentState = 529; break; }
				Expect(38, la); // ")"
				currentState = 523;
				break;
			}
			case 530: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(531);
				goto case 205;
			}
			case 531: {
				PopContext();
				goto case 532;
			}
			case 532: {
				if (la == null) { currentState = 532; break; }
				if (la.kind == 37 || la.kind == 63) {
					if (la.kind == 63) {
						currentState = 537;
						break;
					} else {
						if (la.kind == 37) {
							currentState = 534;
							break;
						} else {
							goto case 533;
						}
					}
				} else {
					goto case 23;
				}
			}
			case 533: {
				Error(la);
				goto case 23;
			}
			case 534: {
				SetIdentifierExpected(la);
				goto case 535;
			}
			case 535: {
				if (la == null) { currentState = 535; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(536);
					goto case 427;
				} else {
					goto case 536;
				}
			}
			case 536: {
				if (la == null) { currentState = 536; break; }
				Expect(38, la); // ")"
				currentState = 23;
				break;
			}
			case 537: {
				PushContext(Context.Type, la, t);
				stateStack.Push(538);
				goto case 37;
			}
			case 538: {
				PopContext();
				goto case 23;
			}
			case 539: {
				PushContext(Context.TypeDeclaration, la, t);
				goto case 540;
			}
			case 540: {
				if (la == null) { currentState = 540; break; }
				Expect(115, la); // "Enum"
				currentState = 541;
				break;
			}
			case 541: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(542);
				goto case 205;
			}
			case 542: {
				PopContext();
				goto case 543;
			}
			case 543: {
				if (la == null) { currentState = 543; break; }
				if (la.kind == 63) {
					currentState = 555;
					break;
				} else {
					goto case 544;
				}
			}
			case 544: {
				stateStack.Push(545);
				goto case 23;
			}
			case 545: {
				SetIdentifierExpected(la);
				goto case 546;
			}
			case 546: {
				if (la == null) { currentState = 546; break; }
				if (set[96].Get(la.kind)) {
					goto case 550;
				} else {
					Expect(113, la); // "End"
					currentState = 547;
					break;
				}
			}
			case 547: {
				if (la == null) { currentState = 547; break; }
				Expect(115, la); // "Enum"
				currentState = 548;
				break;
			}
			case 548: {
				stateStack.Push(549);
				goto case 23;
			}
			case 549: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 550: {
				SetIdentifierExpected(la);
				goto case 551;
			}
			case 551: {
				if (la == null) { currentState = 551; break; }
				if (la.kind == 40) {
					stateStack.Push(550);
					goto case 440;
				} else {
					PushContext(Context.Identifier, la, t);
					SetIdentifierExpected(la);
					stateStack.Push(552);
					goto case 205;
				}
			}
			case 552: {
				PopContext();
				goto case 553;
			}
			case 553: {
				if (la == null) { currentState = 553; break; }
				if (la.kind == 20) {
					currentState = 554;
					break;
				} else {
					goto case 544;
				}
			}
			case 554: {
				stateStack.Push(544);
				goto case 55;
			}
			case 555: {
				PushContext(Context.Type, la, t);
				stateStack.Push(556);
				goto case 37;
			}
			case 556: {
				PopContext();
				goto case 544;
			}
			case 557: {
				if (la == null) { currentState = 557; break; }
				Expect(103, la); // "Delegate"
				currentState = 558;
				break;
			}
			case 558: {
				if (la == null) { currentState = 558; break; }
				if (la.kind == 210) {
					currentState = 559;
					break;
				} else {
					if (la.kind == 127) {
						currentState = 559;
						break;
					} else {
						Error(la);
						goto case 559;
					}
				}
			}
			case 559: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				goto case 560;
			}
			case 560: {
				if (la == null) { currentState = 560; break; }
				currentState = 561;
				break;
			}
			case 561: {
				PopContext();
				goto case 562;
			}
			case 562: {
				if (la == null) { currentState = 562; break; }
				if (la.kind == 37) {
					currentState = 565;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 563;
						break;
					} else {
						goto case 23;
					}
				}
			}
			case 563: {
				PushContext(Context.Type, la, t);
				stateStack.Push(564);
				goto case 37;
			}
			case 564: {
				PopContext();
				goto case 23;
			}
			case 565: {
				SetIdentifierExpected(la);
				goto case 566;
			}
			case 566: {
				if (la == null) { currentState = 566; break; }
				if (set[150].Get(la.kind)) {
					if (la.kind == 169) {
						currentState = 568;
						break;
					} else {
						if (set[77].Get(la.kind)) {
							stateStack.Push(567);
							goto case 427;
						} else {
							Error(la);
							goto case 567;
						}
					}
				} else {
					goto case 567;
				}
			}
			case 567: {
				if (la == null) { currentState = 567; break; }
				Expect(38, la); // ")"
				currentState = 562;
				break;
			}
			case 568: {
				stateStack.Push(567);
				goto case 500;
			}
			case 569: {
				PushContext(Context.TypeDeclaration, la, t);
				goto case 570;
			}
			case 570: {
				if (la == null) { currentState = 570; break; }
				if (la.kind == 155) {
					currentState = 571;
					break;
				} else {
					if (la.kind == 84) {
						currentState = 571;
						break;
					} else {
						if (la.kind == 209) {
							currentState = 571;
							break;
						} else {
							Error(la);
							goto case 571;
						}
					}
				}
			}
			case 571: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(572);
				goto case 205;
			}
			case 572: {
				PopContext();
				goto case 573;
			}
			case 573: {
				if (la == null) { currentState = 573; break; }
				if (la.kind == 37) {
					currentState = 738;
					break;
				} else {
					goto case 574;
				}
			}
			case 574: {
				stateStack.Push(575);
				goto case 23;
			}
			case 575: {
				SetIdentifierExpected(la);
				isMissingModifier = true;
				goto case 576;
			}
			case 576: {
				if (la == null) { currentState = 576; break; }
				if (la.kind == 140) {
					isMissingModifier = false;
					goto case 735;
				} else {
					goto case 577;
				}
			}
			case 577: {
				SetIdentifierExpected(la);
				isMissingModifier = true;
				goto case 578;
			}
			case 578: {
				if (la == null) { currentState = 578; break; }
				if (la.kind == 136) {
					isMissingModifier = false;
					goto case 729;
				} else {
					goto case 579;
				}
			}
			case 579: {
				SetIdentifierExpected(la);
				isMissingModifier = true;
				goto case 580;
			}
			case 580: {
				if (la == null) { currentState = 580; break; }
				if (set[100].Get(la.kind)) {
					goto case 585;
				} else {
					isMissingModifier = false;
					goto case 581;
				}
			}
			case 581: {
				if (la == null) { currentState = 581; break; }
				Expect(113, la); // "End"
				currentState = 582;
				break;
			}
			case 582: {
				if (la == null) { currentState = 582; break; }
				if (la.kind == 155) {
					currentState = 583;
					break;
				} else {
					if (la.kind == 84) {
						currentState = 583;
						break;
					} else {
						if (la.kind == 209) {
							currentState = 583;
							break;
						} else {
							Error(la);
							goto case 583;
						}
					}
				}
			}
			case 583: {
				stateStack.Push(584);
				goto case 23;
			}
			case 584: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 585: {
				SetIdentifierExpected(la);
				isMissingModifier = true;
				goto case 586;
			}
			case 586: {
				if (la == null) { currentState = 586; break; }
				if (la.kind == 40) {
					stateStack.Push(585);
					goto case 440;
				} else {
					isMissingModifier = true;
					goto case 587;
				}
			}
			case 587: {
				SetIdentifierExpected(la);
				goto case 588;
			}
			case 588: {
				if (la == null) { currentState = 588; break; }
				if (set[131].Get(la.kind)) {
					currentState = 728;
					break;
				} else {
					isMissingModifier = false;
					SetIdentifierExpected(la);
					goto case 589;
				}
			}
			case 589: {
				if (la == null) { currentState = 589; break; }
				if (la.kind == 84 || la.kind == 155 || la.kind == 209) {
					stateStack.Push(579);
					goto case 569;
				} else {
					if (la.kind == 103) {
						stateStack.Push(579);
						goto case 557;
					} else {
						if (la.kind == 115) {
							stateStack.Push(579);
							goto case 539;
						} else {
							if (la.kind == 142) {
								stateStack.Push(579);
								goto case 9;
							} else {
								if (set[103].Get(la.kind)) {
									stateStack.Push(579);
									PushContext(Context.Member, la, t);
									SetIdentifierExpected(la);
									goto case 590;
								} else {
									Error(la);
									goto case 579;
								}
							}
						}
					}
				}
			}
			case 590: {
				if (la == null) { currentState = 590; break; }
				if (set[121].Get(la.kind)) {
					stateStack.Push(591);
					goto case 713;
				} else {
					if (la.kind == 127 || la.kind == 210) {
						stateStack.Push(591);
						goto case 695;
					} else {
						if (la.kind == 101) {
							stateStack.Push(591);
							goto case 679;
						} else {
							if (la.kind == 119) {
								stateStack.Push(591);
								goto case 664;
							} else {
								if (la.kind == 98) {
									stateStack.Push(591);
									goto case 652;
								} else {
									if (la.kind == 186) {
										stateStack.Push(591);
										goto case 606;
									} else {
										if (la.kind == 172) {
											stateStack.Push(591);
											goto case 592;
										} else {
											Error(la);
											goto case 591;
										}
									}
								}
							}
						}
					}
				}
			}
			case 591: {
				PopContext();
				currentState = stateStack.Pop();
				goto switchlbl;
			}
			case 592: {
				if (la == null) { currentState = 592; break; }
				Expect(172, la); // "Operator"
				currentState = 593;
				break;
			}
			case 593: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				goto case 594;
			}
			case 594: {
				if (la == null) { currentState = 594; break; }
				currentState = 595;
				break;
			}
			case 595: {
				PopContext();
				goto case 596;
			}
			case 596: {
				if (la == null) { currentState = 596; break; }
				Expect(37, la); // "("
				currentState = 597;
				break;
			}
			case 597: {
				stateStack.Push(598);
				goto case 427;
			}
			case 598: {
				if (la == null) { currentState = 598; break; }
				Expect(38, la); // ")"
				currentState = 599;
				break;
			}
			case 599: {
				if (la == null) { currentState = 599; break; }
				if (la.kind == 63) {
					currentState = 603;
					break;
				} else {
					goto case 600;
				}
			}
			case 600: {
				stateStack.Push(601);
				goto case 262;
			}
			case 601: {
				if (la == null) { currentState = 601; break; }
				Expect(113, la); // "End"
				currentState = 602;
				break;
			}
			case 602: {
				if (la == null) { currentState = 602; break; }
				Expect(172, la); // "Operator"
				currentState = 23;
				break;
			}
			case 603: {
				PushContext(Context.Type, la, t);
				goto case 604;
			}
			case 604: {
				if (la == null) { currentState = 604; break; }
				if (la.kind == 40) {
					stateStack.Push(604);
					goto case 440;
				} else {
					stateStack.Push(605);
					goto case 37;
				}
			}
			case 605: {
				PopContext();
				goto case 600;
			}
			case 606: {
				if (la == null) { currentState = 606; break; }
				Expect(186, la); // "Property"
				currentState = 607;
				break;
			}
			case 607: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(608);
				goto case 205;
			}
			case 608: {
				PopContext();
				goto case 609;
			}
			case 609: {
				if (la == null) { currentState = 609; break; }
				if (la.kind == 37) {
					currentState = 649;
					break;
				} else {
					goto case 610;
				}
			}
			case 610: {
				if (la == null) { currentState = 610; break; }
				if (la.kind == 63) {
					currentState = 646;
					break;
				} else {
					goto case 611;
				}
			}
			case 611: {
				if (la == null) { currentState = 611; break; }
				if (la.kind == 136) {
					currentState = 641;
					break;
				} else {
					goto case 612;
				}
			}
			case 612: {
				if (la == null) { currentState = 612; break; }
				if (la.kind == 20) {
					currentState = 640;
					break;
				} else {
					goto case 613;
				}
			}
			case 613: {
				stateStack.Push(614);
				goto case 23;
			}
			case 614: {
				PopContext();
				goto case 615;
			}
			case 615: {
				if (la == null) { currentState = 615; break; }
				if (la.kind == 40) {
					stateStack.Push(615);
					goto case 440;
				} else {
					goto case 616;
				}
			}
			case 616: {
				if (la == null) { currentState = 616; break; }
				if (set[151].Get(la.kind)) {
					currentState = 639;
					break;
				} else {
					if (la.kind == 128 || la.kind == 198) {
						PushContext(Context.Member, la, t);
						goto case 617;
					} else {
						currentState = stateStack.Pop();
						goto switchlbl;
					}
				}
			}
			case 617: {
				if (la == null) { currentState = 617; break; }
				if (la.kind == 128) {
					currentState = 618;
					break;
				} else {
					if (la.kind == 198) {
						currentState = 618;
						break;
					} else {
						Error(la);
						goto case 618;
					}
				}
			}
			case 618: {
				if (la == null) { currentState = 618; break; }
				if (la.kind == 37) {
					currentState = 636;
					break;
				} else {
					goto case 619;
				}
			}
			case 619: {
				stateStack.Push(620);
				goto case 262;
			}
			case 620: {
				if (la == null) { currentState = 620; break; }
				Expect(113, la); // "End"
				currentState = 621;
				break;
			}
			case 621: {
				if (la == null) { currentState = 621; break; }
				if (la.kind == 128) {
					currentState = 622;
					break;
				} else {
					if (la.kind == 198) {
						currentState = 622;
						break;
					} else {
						Error(la);
						goto case 622;
					}
				}
			}
			case 622: {
				stateStack.Push(623);
				goto case 23;
			}
			case 623: {
				if (la == null) { currentState = 623; break; }
				if (set[109].Get(la.kind)) {
					goto case 626;
				} else {
					goto case 624;
				}
			}
			case 624: {
				if (la == null) { currentState = 624; break; }
				Expect(113, la); // "End"
				currentState = 625;
				break;
			}
			case 625: {
				if (la == null) { currentState = 625; break; }
				Expect(186, la); // "Property"
				currentState = 23;
				break;
			}
			case 626: {
				if (la == null) { currentState = 626; break; }
				if (la.kind == 40) {
					stateStack.Push(626);
					goto case 440;
				} else {
					goto case 627;
				}
			}
			case 627: {
				if (la == null) { currentState = 627; break; }
				if (set[151].Get(la.kind)) {
					currentState = 627;
					break;
				} else {
					if (la.kind == 128) {
						currentState = 628;
						break;
					} else {
						if (la.kind == 198) {
							currentState = 628;
							break;
						} else {
							Error(la);
							goto case 628;
						}
					}
				}
			}
			case 628: {
				if (la == null) { currentState = 628; break; }
				if (la.kind == 37) {
					currentState = 633;
					break;
				} else {
					goto case 629;
				}
			}
			case 629: {
				stateStack.Push(630);
				goto case 262;
			}
			case 630: {
				if (la == null) { currentState = 630; break; }
				Expect(113, la); // "End"
				currentState = 631;
				break;
			}
			case 631: {
				if (la == null) { currentState = 631; break; }
				if (la.kind == 128) {
					currentState = 632;
					break;
				} else {
					if (la.kind == 198) {
						currentState = 632;
						break;
					} else {
						Error(la);
						goto case 632;
					}
				}
			}
			case 632: {
				stateStack.Push(624);
				goto case 23;
			}
			case 633: {
				SetIdentifierExpected(la);
				goto case 634;
			}
			case 634: {
				if (la == null) { currentState = 634; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(635);
					goto case 427;
				} else {
					goto case 635;
				}
			}
			case 635: {
				if (la == null) { currentState = 635; break; }
				Expect(38, la); // ")"
				currentState = 629;
				break;
			}
			case 636: {
				SetIdentifierExpected(la);
				goto case 637;
			}
			case 637: {
				if (la == null) { currentState = 637; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(638);
					goto case 427;
				} else {
					goto case 638;
				}
			}
			case 638: {
				if (la == null) { currentState = 638; break; }
				Expect(38, la); // ")"
				currentState = 619;
				break;
			}
			case 639: {
				SetIdentifierExpected(la);
				goto case 616;
			}
			case 640: {
				stateStack.Push(613);
				goto case 55;
			}
			case 641: {
				PushContext(Context.Type, la, t);
				stateStack.Push(642);
				goto case 37;
			}
			case 642: {
				PopContext();
				goto case 643;
			}
			case 643: {
				if (la == null) { currentState = 643; break; }
				if (la.kind == 22) {
					currentState = 644;
					break;
				} else {
					goto case 612;
				}
			}
			case 644: {
				PushContext(Context.Type, la, t);
				stateStack.Push(645);
				goto case 37;
			}
			case 645: {
				PopContext();
				goto case 643;
			}
			case 646: {
				PushContext(Context.Type, la, t);
				goto case 647;
			}
			case 647: {
				if (la == null) { currentState = 647; break; }
				if (la.kind == 40) {
					stateStack.Push(647);
					goto case 440;
				} else {
					if (la.kind == 162) {
						stateStack.Push(648);
						goto case 85;
					} else {
						if (set[16].Get(la.kind)) {
							stateStack.Push(648);
							goto case 37;
						} else {
							Error(la);
							goto case 648;
						}
					}
				}
			}
			case 648: {
				PopContext();
				goto case 611;
			}
			case 649: {
				SetIdentifierExpected(la);
				goto case 650;
			}
			case 650: {
				if (la == null) { currentState = 650; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(651);
					goto case 427;
				} else {
					goto case 651;
				}
			}
			case 651: {
				if (la == null) { currentState = 651; break; }
				Expect(38, la); // ")"
				currentState = 610;
				break;
			}
			case 652: {
				if (la == null) { currentState = 652; break; }
				Expect(98, la); // "Custom"
				currentState = 653;
				break;
			}
			case 653: {
				stateStack.Push(654);
				goto case 664;
			}
			case 654: {
				if (la == null) { currentState = 654; break; }
				if (set[114].Get(la.kind)) {
					goto case 656;
				} else {
					Expect(113, la); // "End"
					currentState = 655;
					break;
				}
			}
			case 655: {
				if (la == null) { currentState = 655; break; }
				Expect(119, la); // "Event"
				currentState = 23;
				break;
			}
			case 656: {
				if (la == null) { currentState = 656; break; }
				if (la.kind == 40) {
					stateStack.Push(656);
					goto case 440;
				} else {
					if (la.kind == 56) {
						currentState = 657;
						break;
					} else {
						if (la.kind == 193) {
							currentState = 657;
							break;
						} else {
							if (la.kind == 189) {
								currentState = 657;
								break;
							} else {
								Error(la);
								goto case 657;
							}
						}
					}
				}
			}
			case 657: {
				if (la == null) { currentState = 657; break; }
				Expect(37, la); // "("
				currentState = 658;
				break;
			}
			case 658: {
				stateStack.Push(659);
				goto case 427;
			}
			case 659: {
				if (la == null) { currentState = 659; break; }
				Expect(38, la); // ")"
				currentState = 660;
				break;
			}
			case 660: {
				stateStack.Push(661);
				goto case 262;
			}
			case 661: {
				if (la == null) { currentState = 661; break; }
				Expect(113, la); // "End"
				currentState = 662;
				break;
			}
			case 662: {
				if (la == null) { currentState = 662; break; }
				if (la.kind == 56) {
					currentState = 663;
					break;
				} else {
					if (la.kind == 193) {
						currentState = 663;
						break;
					} else {
						if (la.kind == 189) {
							currentState = 663;
							break;
						} else {
							Error(la);
							goto case 663;
						}
					}
				}
			}
			case 663: {
				stateStack.Push(654);
				goto case 23;
			}
			case 664: {
				if (la == null) { currentState = 664; break; }
				Expect(119, la); // "Event"
				currentState = 665;
				break;
			}
			case 665: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(666);
				goto case 205;
			}
			case 666: {
				PopContext();
				goto case 667;
			}
			case 667: {
				if (la == null) { currentState = 667; break; }
				if (la.kind == 63) {
					currentState = 677;
					break;
				} else {
					if (set[152].Get(la.kind)) {
						if (la.kind == 37) {
							currentState = 674;
							break;
						} else {
							goto case 668;
						}
					} else {
						Error(la);
						goto case 668;
					}
				}
			}
			case 668: {
				if (la == null) { currentState = 668; break; }
				if (la.kind == 136) {
					currentState = 669;
					break;
				} else {
					goto case 23;
				}
			}
			case 669: {
				PushContext(Context.Type, la, t);
				stateStack.Push(670);
				goto case 37;
			}
			case 670: {
				PopContext();
				goto case 671;
			}
			case 671: {
				if (la == null) { currentState = 671; break; }
				if (la.kind == 22) {
					currentState = 672;
					break;
				} else {
					goto case 23;
				}
			}
			case 672: {
				PushContext(Context.Type, la, t);
				stateStack.Push(673);
				goto case 37;
			}
			case 673: {
				PopContext();
				goto case 671;
			}
			case 674: {
				SetIdentifierExpected(la);
				goto case 675;
			}
			case 675: {
				if (la == null) { currentState = 675; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(676);
					goto case 427;
				} else {
					goto case 676;
				}
			}
			case 676: {
				if (la == null) { currentState = 676; break; }
				Expect(38, la); // ")"
				currentState = 668;
				break;
			}
			case 677: {
				PushContext(Context.Type, la, t);
				stateStack.Push(678);
				goto case 37;
			}
			case 678: {
				PopContext();
				goto case 668;
			}
			case 679: {
				if (la == null) { currentState = 679; break; }
				Expect(101, la); // "Declare"
				currentState = 680;
				break;
			}
			case 680: {
				if (la == null) { currentState = 680; break; }
				if (la.kind == 62 || la.kind == 66 || la.kind == 223) {
					currentState = 681;
					break;
				} else {
					goto case 681;
				}
			}
			case 681: {
				if (la == null) { currentState = 681; break; }
				if (la.kind == 210) {
					currentState = 682;
					break;
				} else {
					if (la.kind == 127) {
						currentState = 682;
						break;
					} else {
						Error(la);
						goto case 682;
					}
				}
			}
			case 682: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(683);
				goto case 205;
			}
			case 683: {
				PopContext();
				goto case 684;
			}
			case 684: {
				if (la == null) { currentState = 684; break; }
				Expect(149, la); // "Lib"
				currentState = 685;
				break;
			}
			case 685: {
				if (la == null) { currentState = 685; break; }
				Expect(3, la); // LiteralString
				currentState = 686;
				break;
			}
			case 686: {
				if (la == null) { currentState = 686; break; }
				if (la.kind == 59) {
					currentState = 694;
					break;
				} else {
					goto case 687;
				}
			}
			case 687: {
				if (la == null) { currentState = 687; break; }
				if (la.kind == 37) {
					currentState = 691;
					break;
				} else {
					goto case 688;
				}
			}
			case 688: {
				if (la == null) { currentState = 688; break; }
				if (la.kind == 63) {
					currentState = 689;
					break;
				} else {
					goto case 23;
				}
			}
			case 689: {
				PushContext(Context.Type, la, t);
				stateStack.Push(690);
				goto case 37;
			}
			case 690: {
				PopContext();
				goto case 23;
			}
			case 691: {
				SetIdentifierExpected(la);
				goto case 692;
			}
			case 692: {
				if (la == null) { currentState = 692; break; }
				if (set[77].Get(la.kind)) {
					stateStack.Push(693);
					goto case 427;
				} else {
					goto case 693;
				}
			}
			case 693: {
				if (la == null) { currentState = 693; break; }
				Expect(38, la); // ")"
				currentState = 688;
				break;
			}
			case 694: {
				if (la == null) { currentState = 694; break; }
				Expect(3, la); // LiteralString
				currentState = 687;
				break;
			}
			case 695: {
				if (la == null) { currentState = 695; break; }
				if (la.kind == 210) {
					currentState = 696;
					break;
				} else {
					if (la.kind == 127) {
						currentState = 696;
						break;
					} else {
						Error(la);
						goto case 696;
					}
				}
			}
			case 696: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				goto case 697;
			}
			case 697: {
				if (la == null) { currentState = 697; break; }
				currentState = 698;
				break;
			}
			case 698: {
				PopContext();
				goto case 699;
			}
			case 699: {
				if (la == null) { currentState = 699; break; }
				if (la.kind == 37) {
					currentState = 709;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 707;
						break;
					} else {
						goto case 700;
					}
				}
			}
			case 700: {
				if (la == null) { currentState = 700; break; }
				if (la.kind == 134 || la.kind == 136) {
					currentState = 704;
					break;
				} else {
					goto case 701;
				}
			}
			case 701: {
				stateStack.Push(702);
				goto case 262;
			}
			case 702: {
				if (la == null) { currentState = 702; break; }
				Expect(113, la); // "End"
				currentState = 703;
				break;
			}
			case 703: {
				if (la == null) { currentState = 703; break; }
				if (la.kind == 210) {
					currentState = 23;
					break;
				} else {
					if (la.kind == 127) {
						currentState = 23;
						break;
					} else {
						goto case 533;
					}
				}
			}
			case 704: {
				if (la == null) { currentState = 704; break; }
				if (la.kind == 153 || la.kind == 158 || la.kind == 159) {
					currentState = 706;
					break;
				} else {
					goto case 705;
				}
			}
			case 705: {
				stateStack.Push(701);
				goto case 37;
			}
			case 706: {
				if (la == null) { currentState = 706; break; }
				Expect(26, la); // "."
				currentState = 705;
				break;
			}
			case 707: {
				PushContext(Context.Type, la, t);
				stateStack.Push(708);
				goto case 37;
			}
			case 708: {
				PopContext();
				goto case 700;
			}
			case 709: {
				SetIdentifierExpected(la);
				goto case 710;
			}
			case 710: {
				if (la == null) { currentState = 710; break; }
				if (set[150].Get(la.kind)) {
					if (la.kind == 169) {
						currentState = 712;
						break;
					} else {
						if (set[77].Get(la.kind)) {
							stateStack.Push(711);
							goto case 427;
						} else {
							Error(la);
							goto case 711;
						}
					}
				} else {
					goto case 711;
				}
			}
			case 711: {
				if (la == null) { currentState = 711; break; }
				Expect(38, la); // ")"
				currentState = 699;
				break;
			}
			case 712: {
				stateStack.Push(711);
				goto case 500;
			}
			case 713: {
				stateStack.Push(714);
				SetIdentifierExpected(la);
				goto case 715;
			}
			case 714: {
				if (la == null) { currentState = 714; break; }
				if (la.kind == 22) {
					currentState = 713;
					break;
				} else {
					goto case 23;
				}
			}
			case 715: {
				if (la == null) { currentState = 715; break; }
				if (la.kind == 88) {
					currentState = 716;
					break;
				} else {
					goto case 716;
				}
			}
			case 716: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				stateStack.Push(717);
				goto case 727;
			}
			case 717: {
				PopContext();
				goto case 718;
			}
			case 718: {
				if (la == null) { currentState = 718; break; }
				if (la.kind == 33) {
					currentState = 719;
					break;
				} else {
					goto case 719;
				}
			}
			case 719: {
				if (la == null) { currentState = 719; break; }
				if (la.kind == 37) {
					currentState = 724;
					break;
				} else {
					if (la.kind == 63) {
						currentState = 721;
						break;
					} else {
						goto case 720;
					}
				}
			}
			case 720: {
				if (la == null) { currentState = 720; break; }
				if (la.kind == 20) {
					currentState = 55;
					break;
				} else {
					currentState = stateStack.Pop();
					goto switchlbl;
				}
			}
			case 721: {
				PushContext(Context.Type, la, t);
				goto case 722;
			}
			case 722: {
				if (la == null) { currentState = 722; break; }
				if (la.kind == 162) {
					stateStack.Push(723);
					goto case 85;
				} else {
					if (set[16].Get(la.kind)) {
						stateStack.Push(723);
						goto case 37;
					} else {
						Error(la);
						goto case 723;
					}
				}
			}
			case 723: {
				PopContext();
				goto case 720;
			}
			case 724: {
				nextTokenIsPotentialStartOfExpression = true;
				goto case 725;
			}
			case 725: {
				if (la == null) { currentState = 725; break; }
				if (set[23].Get(la.kind)) {
					stateStack.Push(726);
					goto case 55;
				} else {
					goto case 726;
				}
			}
			case 726: {
				if (la == null) { currentState = 726; break; }
				if (la.kind == 22) {
					currentState = 724;
					break;
				} else {
					Expect(38, la); // ")"
					currentState = 719;
					break;
				}
			}
			case 727: {
				if (la == null) { currentState = 727; break; }
				if (set[136].Get(la.kind)) {
					currentState = stateStack.Pop();
					break;
				} else {
					if (la.kind == 58) {
						goto case 144;
					} else {
						if (la.kind == 126) {
							goto case 128;
						} else {
							goto case 6;
						}
					}
				}
			}
			case 728: {
				isMissingModifier = false;
				goto case 587;
			}
			case 729: {
				if (la == null) { currentState = 729; break; }
				Expect(136, la); // "Implements"
				currentState = 730;
				break;
			}
			case 730: {
				PushContext(Context.Type, la, t);
				stateStack.Push(731);
				goto case 37;
			}
			case 731: {
				PopContext();
				goto case 732;
			}
			case 732: {
				if (la == null) { currentState = 732; break; }
				if (la.kind == 22) {
					currentState = 733;
					break;
				} else {
					stateStack.Push(579);
					goto case 23;
				}
			}
			case 733: {
				PushContext(Context.Type, la, t);
				stateStack.Push(734);
				goto case 37;
			}
			case 734: {
				PopContext();
				goto case 732;
			}
			case 735: {
				if (la == null) { currentState = 735; break; }
				Expect(140, la); // "Inherits"
				currentState = 736;
				break;
			}
			case 736: {
				PushContext(Context.Type, la, t);
				stateStack.Push(737);
				goto case 37;
			}
			case 737: {
				PopContext();
				stateStack.Push(577);
				goto case 23;
			}
			case 738: {
				if (la == null) { currentState = 738; break; }
				Expect(169, la); // "Of"
				currentState = 739;
				break;
			}
			case 739: {
				stateStack.Push(740);
				goto case 500;
			}
			case 740: {
				if (la == null) { currentState = 740; break; }
				Expect(38, la); // ")"
				currentState = 574;
				break;
			}
			case 741: {
				isMissingModifier = false;
				goto case 28;
			}
			case 742: {
				PushContext(Context.Type, la, t);
				stateStack.Push(743);
				goto case 37;
			}
			case 743: {
				PopContext();
				goto case 744;
			}
			case 744: {
				if (la == null) { currentState = 744; break; }
				if (la.kind == 22) {
					currentState = 745;
					break;
				} else {
					stateStack.Push(17);
					goto case 23;
				}
			}
			case 745: {
				PushContext(Context.Type, la, t);
				stateStack.Push(746);
				goto case 37;
			}
			case 746: {
				PopContext();
				goto case 744;
			}
			case 747: {
				if (la == null) { currentState = 747; break; }
				Expect(169, la); // "Of"
				currentState = 748;
				break;
			}
			case 748: {
				stateStack.Push(749);
				goto case 500;
			}
			case 749: {
				if (la == null) { currentState = 749; break; }
				Expect(38, la); // ")"
				currentState = 14;
				break;
			}
			case 750: {
				PushContext(Context.Identifier, la, t);
				SetIdentifierExpected(la);
				goto case 751;
			}
			case 751: {
				if (la == null) { currentState = 751; break; }
				if (set[50].Get(la.kind)) {
					currentState = 751;
					break;
				} else {
					PopContext();
					stateStack.Push(752);
					goto case 23;
				}
			}
			case 752: {
				if (la == null) { currentState = 752; break; }
				if (set[3].Get(la.kind)) {
					stateStack.Push(752);
					goto case 5;
				} else {
					Expect(113, la); // "End"
					currentState = 753;
					break;
				}
			}
			case 753: {
				if (la == null) { currentState = 753; break; }
				Expect(160, la); // "Namespace"
				currentState = 23;
				break;
			}
			case 754: {
				if (la == null) { currentState = 754; break; }
				Expect(137, la); // "Imports"
				currentState = 755;
				break;
			}
			case 755: {
				PushContext(Context.Importable, la, t);
				nextTokenIsStartOfImportsOrAccessExpression = true;	
				goto case 756;
			}
			case 756: {
				if (la == null) { currentState = 756; break; }
				if (set[153].Get(la.kind)) {
					currentState = 762;
					break;
				} else {
					if (la.kind == 10) {
						currentState = 758;
						break;
					} else {
						Error(la);
						goto case 757;
					}
				}
			}
			case 757: {
				PopContext();
				goto case 23;
			}
			case 758: {
				stateStack.Push(759);
				goto case 205;
			}
			case 759: {
				if (la == null) { currentState = 759; break; }
				Expect(20, la); // "="
				currentState = 760;
				break;
			}
			case 760: {
				if (la == null) { currentState = 760; break; }
				Expect(3, la); // LiteralString
				currentState = 761;
				break;
			}
			case 761: {
				if (la == null) { currentState = 761; break; }
				Expect(11, la); // XmlCloseTag
				currentState = 757;
				break;
			}
			case 762: {
				if (la == null) { currentState = 762; break; }
				if (la.kind == 37) {
					stateStack.Push(762);
					goto case 42;
				} else {
					if (la.kind == 20 || la.kind == 26) {
						currentState = 763;
						break;
					} else {
						goto case 757;
					}
				}
			}
			case 763: {
				stateStack.Push(757);
				goto case 37;
			}
			case 764: {
				if (la == null) { currentState = 764; break; }
				Expect(173, la); // "Option"
				currentState = 765;
				break;
			}
			case 765: {
				if (la == null) { currentState = 765; break; }
				if (la.kind == 121 || la.kind == 139 || la.kind == 207) {
					currentState = 767;
					break;
				} else {
					if (la.kind == 87) {
						currentState = 766;
						break;
					} else {
						goto case 533;
					}
				}
			}
			case 766: {
				if (la == null) { currentState = 766; break; }
				if (la.kind == 213) {
					currentState = 23;
					break;
				} else {
					if (la.kind == 67) {
						currentState = 23;
						break;
					} else {
						goto case 533;
					}
				}
			}
			case 767: {
				if (la == null) { currentState = 767; break; }
				if (la.kind == 170 || la.kind == 171) {
					currentState = 23;
					break;
				} else {
					goto case 23;
				}
			}
		}

		if (la != null) {
			t = la;
			nextTokenIsPotentialStartOfExpression = false;
			readXmlIdentifier = false;
			nextTokenIsStartOfImportsOrAccessExpression = false;
			wasQualifierTokenAtStart = false;
			identifierExpected = false;
		}
	}
	
	public void Advance()
	{
		//Console.WriteLine("Advance");
		InformToken(null);
	}
	
	public BitArray GetExpectedSet() { return GetExpectedSet(currentState); }
	
	static readonly BitArray[] set = {
		new BitArray(new int[] {1, 256, 1048576, 537395328, 402670080, 444604481, 131200, 0}),
		new BitArray(new int[] {1, 256, 1048576, 537395328, 402670080, 444596289, 131200, 0}),
		new BitArray(new int[] {1, 256, 1048576, 537395328, 402669568, 444596289, 131200, 0}),
		new BitArray(new int[] {0, 256, 1048576, 537395328, 402669568, 444596289, 131200, 0}),
		new BitArray(new int[] {0, 256, 1048576, 537395328, 402669568, 444596288, 131200, 0}),
		new BitArray(new int[] {0, 0, 1048576, 537395328, 402669568, 444596288, 131200, 0}),
		new BitArray(new int[] {4, 1140850688, 8388687, 1108347140, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {0, 256, 1048576, -1601568064, 671109120, 1589117122, 393600, 3328}),
		new BitArray(new int[] {0, 256, 1048576, -1601568064, 671105024, 1589117122, 393600, 3328}),
		new BitArray(new int[] {5, 1140850944, 26214479, -493220892, 940361760, 1606227139, -2143942272, 3393}),
		new BitArray(new int[] {0, 256, 1048576, -1601699136, 671105024, 1589117122, 393600, 3328}),
		new BitArray(new int[] {0, 0, 1048576, -1601699136, 671105024, 1589117122, 393600, 3328}),
		new BitArray(new int[] {0, 0, 1048576, -2138570624, 134234112, 67108864, 393216, 0}),
		new BitArray(new int[] {0, 0, 0, -2139095040, 0, 67108864, 262144, 0}),
		new BitArray(new int[] {-2, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {2097154, -2147483616, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850690, 8650975, 1108355356, 9218084, 17106176, -533656048, 67}),
		new BitArray(new int[] {-940564478, 889192445, 65, 1074825472, 72844640, 231424, 22030368, 4704}),
		new BitArray(new int[] {-940564478, 889192413, 65, 1074825472, 72844640, 231424, 22030368, 4704}),
		new BitArray(new int[] {4, -16777216, -1, -1, -1, -1, -1, 16383}),
		new BitArray(new int[] {-61995012, 1174405224, -51384097, -972018405, -1030969182, 17106740, -97186288, 8259}),
		new BitArray(new int[] {-61995012, 1174405160, -51384097, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-61995012, 1174405224, -51384097, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-66189316, 1174405160, -51384097, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-1007673342, 889192405, 65, 1074825472, 72843296, 231424, 22030368, 4160}),
		new BitArray(new int[] {-1013972992, 822083461, 0, 0, 71499776, 163840, 16777216, 4096}),
		new BitArray(new int[] {-66189316, 1174405176, -51384097, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {4, 1140850690, 8650975, 1108355356, 9218084, 17106176, -533656048, 579}),
		new BitArray(new int[] {-1007673342, 889192405, 65, 1074825472, 72843552, 231424, 22030368, 4160}),
		new BitArray(new int[] {-1007673342, 889192413, 65, 1074825472, 72843552, 231424, 22030368, 4672}),
		new BitArray(new int[] {-2, -9, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-1040382, 889192437, 65, 1074825472, 72843296, 231424, 22030368, 4160}),
		new BitArray(new int[] {1006632960, 32, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {1028, -16777216, -1, -1, -1, -1, -1, 16383}),
		new BitArray(new int[] {-1038334, -1258291211, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {1007552508, 1140850720, -51384097, -972018405, -1030969182, 17106208, -365621744, 8259}),
		new BitArray(new int[] {-1040382, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {0, 0, -60035072, 1027, 0, 0, 134217728, 0}),
		new BitArray(new int[] {0, 67108864, 0, 1073743872, 1310752, 65536, 1050656, 64}),
		new BitArray(new int[] {4194304, 67108864, 0, 1073743872, 1343520, 65536, 1050656, 64}),
		new BitArray(new int[] {-66189316, 1174405160, -51384097, -972018401, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {4194304, 67108864, 64, 1073743872, 1343520, 65536, 1050656, 64}),
		new BitArray(new int[] {66189314, -1174405161, 51384096, 972018404, 1030969181, -17106229, 97186287, -8260}),
		new BitArray(new int[] {65140738, 973078487, 51384096, 972018404, 1030969181, -17106229, 97186287, -8260}),
		new BitArray(new int[] {-66189316, 1174405160, -51384097, -972018405, -1030969182, 17106228, -97186288, 8387}),
		new BitArray(new int[] {0, 67108864, 0, 1073743872, 1343520, 65536, 1050656, 64}),
		new BitArray(new int[] {4, 1140851008, 8388975, 1108347140, 821280, 21316608, -2144335872, 65}),
		new BitArray(new int[] {-64092162, -973078488, -51384097, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-64092162, 1191182376, -1048865, -546062565, -1014191950, -1593504452, -21144002, 8903}),
		new BitArray(new int[] {0, 0, 3072, 134447104, 16777216, 8, 0, 0}),
		new BitArray(new int[] {-2097156, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-66189316, 1191182376, -1051937, -680509669, -1030969166, -1593504460, -21144002, 8903}),
		new BitArray(new int[] {-66189316, 1174405162, -51384097, -972018401, -1030969178, 17106228, -97186288, 8259}),
		new BitArray(new int[] {6291458, 0, 0, 32768, 0, 0, 0, 0}),
		new BitArray(new int[] {-64092162, 1174405160, -51384097, -971985637, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {0, 0, 0, -1879044096, 0, 67108864, 67371040, 128}),
		new BitArray(new int[] {36, 1140850688, 8388687, 1108347140, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {2097158, 1140850688, 8388687, 1108347140, 821280, 17105920, -2144335872, 97}),
		new BitArray(new int[] {2097154, -2147483648, 0, 0, 0, 0, 0, 32}),
		new BitArray(new int[] {36, 1140850688, 8388687, 1108347140, 821280, 17105928, -2144335872, 65}),
		new BitArray(new int[] {-66189316, 1174405160, -51384097, -972018405, -1030969166, 17106228, -97186284, 8259}),
		new BitArray(new int[] {1007552508, 1140850720, -51384097, -972002021, -1030969182, 17106208, -365621744, 8259}),
		new BitArray(new int[] {1007681536, -2147483614, 0, 0, 1024, 0, 0, 0}),
		new BitArray(new int[] {1007681536, -2147483616, 0, 0, 1024, 0, 0, 0}),
		new BitArray(new int[] {2097154, 0, 0, 0, 0, 0, 0, 129}),
		new BitArray(new int[] {2097154, 0, 0, 32768, 0, 0, 0, 129}),
		new BitArray(new int[] {-66189316, 1174405160, -51383073, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-65140740, 1174409128, -51384097, -971985637, -1030903646, 17106228, -97186288, 8259}),
		new BitArray(new int[] {-65140740, 1174409128, -51384097, -972018405, -1030903646, 17106228, -97186288, 8259}),
		new BitArray(new int[] {1048576, 3968, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {-64092162, 1191182376, -1051937, -680509669, -1030969166, -1593504460, -21144002, 8903}),
		new BitArray(new int[] {-64092162, 1191182376, -1051937, -680476901, -1030969166, -1593504460, -21144002, 8903}),
		new BitArray(new int[] {2097154, 32, 0, 32768, 0, 0, 0, 0}),
		new BitArray(new int[] {7340034, -2147483614, 0, 32768, 0, 0, 0, 0}),
		new BitArray(new int[] {7340034, -2147483616, 0, 32768, 0, 0, 0, 0}),
		new BitArray(new int[] {7340034, 0, 0, 32768, 0, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850690, 8650975, 1108355356, 9218084, 17106180, -533656048, 67}),
		new BitArray(new int[] {4, 1140850944, 8388975, 1108347140, 821280, 21316608, -2144335872, 65}),
		new BitArray(new int[] {4, 1140850688, 8388975, 1108347140, 821280, 21316608, -2144335872, 65}),
		new BitArray(new int[] {5242880, -2147483584, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {-2, -1, -3, -1, -134217729, -1, -1, -1}),
		new BitArray(new int[] {7, 1157628162, 26477055, -493212676, 948758565, 2147308999, -533262382, 3395}),
		new BitArray(new int[] {918528, 0, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {-909310, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {-843774, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {-318462, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {-383998, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {-1038334, -1258291209, 65, 1074825472, 72844320, 231424, 22030368, 4160}),
		new BitArray(new int[] {4194308, 1140850754, 8650975, 1108355356, 9218084, 17106176, -533656048, 67}),
		new BitArray(new int[] {4, 1140851008, 8388975, 1108347140, 821280, 21317120, -2144335872, 65}),
		new BitArray(new int[] {4, 1073741824, 8388687, 34605312, 822304, 17105920, -2144335872, 65}),
		new BitArray(new int[] {4, 1073741824, 8388687, 34605312, 821280, 16843776, -2144335872, 65}),
		new BitArray(new int[] {4, 1140850698, 9699551, 1108355356, 9218084, 17106180, -533524976, 67}),
		new BitArray(new int[] {4, 1140850690, 9699551, 1108355356, 9218084, 17106180, -533524976, 67}),
		new BitArray(new int[] {4, 1140850946, 8650975, 1108355356, 9218084, 17106176, -533656048, 67}),
		new BitArray(new int[] {4, 1140850944, 8388687, 1108478212, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {4, 1140850944, 8388687, 1108347140, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {4, 1140850944, 26214479, -493220892, 671930656, 1606227138, -2143942272, 3393}),
		new BitArray(new int[] {4, 1140850944, 26214479, -493220892, 671926560, 1606227138, -2143942272, 3393}),
		new BitArray(new int[] {4, 1140850944, 26214479, -493220892, 671926304, 1606227138, -2143942272, 3393}),
		new BitArray(new int[] {4, 1140850944, 26214479, -493351964, 671926304, 1606227138, -2143942272, 3393}),
		new BitArray(new int[] {4, 1140850688, 26214479, -493351964, 671926304, 1606227138, -2143942272, 3393}),
		new BitArray(new int[] {4, 1140850688, 26214479, -1030223452, 135055392, 84218880, -2143942656, 65}),
		new BitArray(new int[] {4, 1140850688, 25165903, -1030747868, 821280, 84218880, -2144073728, 65}),
		new BitArray(new int[] {3145730, -2147483616, 0, 0, 256, 0, 0, 0}),
		new BitArray(new int[] {3145730, -2147483648, 0, 0, 256, 0, 0, 0}),
		new BitArray(new int[] {3145730, 0, 0, 0, 256, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850944, 26214479, -493220892, 671926305, 1606227138, -2143942208, 3393}),
		new BitArray(new int[] {0, 256, 0, 537001984, 1, 436207616, 64, 0}),
		new BitArray(new int[] {0, 256, 0, 536870912, 1, 436207616, 64, 0}),
		new BitArray(new int[] {0, 0, 0, 536870912, 1, 436207616, 64, 0}),
		new BitArray(new int[] {7340034, 0, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850946, 8650975, 1108355356, 9218084, 17106180, -533656048, 67}),
		new BitArray(new int[] {0, 16777472, 0, 131072, 0, 536870912, 2, 0}),
		new BitArray(new int[] {0, 16777472, 0, 0, 0, 536870912, 2, 0}),
		new BitArray(new int[] {2097154, -2147483616, 0, 0, 256, 0, 0, 0}),
		new BitArray(new int[] {0, 1073741824, 4, -2147483648, 0, 0, -2147221504, 0}),
		new BitArray(new int[] {2097154, -2013265888, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {2097154, -2147483616, 0, 0, 320, 0, 0, 0}),
		new BitArray(new int[] {2097154, 0, 0, 0, 320, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850690, 8650975, 1108355356, -1030969308, 17106176, -533656048, 67}),
		new BitArray(new int[] {4, 1140850688, 25165903, 1108347136, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {4, 1140850688, 8388687, 1108347136, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {7340034, -2147483614, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {7340034, -2147483616, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {0, 256, 1048576, 537526400, 402669568, 444596289, 131200, 0}),
		new BitArray(new int[] {1028, 1140850688, 8650975, 1108355356, 9218084, 17106176, -533656048, 67}),
		new BitArray(new int[] {70254594, 32, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {0, 0, 8388608, 33554432, 2048, 0, 32768, 0}),
		new BitArray(new int[] {2097154, 0, 0, 0, 0, 3072, 0, 0}),
		new BitArray(new int[] {0, 0, 0, 536870912, 268435456, 444596288, 128, 0}),
		new BitArray(new int[] {0, 0, 0, 536871488, 536870912, 1522008258, 384, 3328}),
		new BitArray(new int[] {0, 0, 262288, 8216, 8396800, 256, 1610679824, 2}),
		new BitArray(new int[] {-1073741824, 33554432, 0, 0, 0, 16, 0, 0}),
		new BitArray(new int[] {1006632960, 0, 0, 0, 0, 0, 0, 0}),
		new BitArray(new int[] {1016, 0, 0, 67108864, -1040187392, 32, 33554432, 0}),
		new BitArray(new int[] {4, 1073741824, 8388687, 34605312, 821280, 17105920, -2144335872, 65}),
		new BitArray(new int[] {0, 0, -1133776896, 3, 0, 0, 0, 0}),
		new BitArray(new int[] {-64092162, 1191182376, -1051937, -680378597, -1030969166, -1593504460, -21144002, 8903}),
		new BitArray(new int[] {0, 0, 33554432, 16777216, 16, 0, 16392, 0}),
		new BitArray(new int[] {-66189316, 1174405160, -51383585, -972018405, -1030969182, 17106228, -97186288, 8259}),
		new BitArray(new int[] {1048576, 3968, 0, 0, 65536, 0, 0, 0}),
		new BitArray(new int[] {0, 0, 288, 0, 0, 4210688, 0, 0}),
		new BitArray(new int[] {-2, -129, -3, -1, -134217729, -1, -1, -1}),
		new BitArray(new int[] {-18434, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-22530, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-32770, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-37890, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-2050, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {-6146, -1, -1, -1, -1, -1, -1, -1}),
		new BitArray(new int[] {4, 1140850944, 8388975, 1108347140, 821280, 21317120, -2144335872, 65}),
		new BitArray(new int[] {0, 0, 0, 536870912, 0, 436207616, 0, 0}),
		new BitArray(new int[] {2097154, 32, 0, 0, 256, 0, 0, 0}),
		new BitArray(new int[] {4, 1140850688, 8650975, 1108355356, 9218084, 17106176, -533656048, 67})

	};

} // end Parser


}