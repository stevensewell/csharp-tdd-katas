namespace NumbersInWords;

public partial class NumberInWordsUnitTests
{
    private static IList<(decimal, string)> _21To99Source = new List<(decimal, string)>
    {
        (21, "twenty one"),
        (22, "twenty two"),
        (23, "twenty three"),
        (24, "twenty four"),
        (25, "twenty five"),
        (26, "twenty six"),
        (27, "twenty seven"),
        (28, "twenty eight"),
        (29, "twenty nine"),
        (30, "thirty"),
        (31, "thirty one"),
        (32, "thirty two"),
        (33, "thirty three"),
        (34, "thirty four"),
        (35, "thirty five"),
        (36, "thirty six"),
        (37, "thirty seven"),
        (38, "thirty eight"),
        (39, "thirty nine"),
        (40, "forty"),
        (41, "forty one"),
        (42, "forty two"),
        (43, "forty three"),
        (44, "forty four"),
        (45, "forty five"),
        (46, "forty six"),
        (47, "forty seven"),
        (48, "forty eight"),
        (49, "forty nine"),
        (50, "fifty"),
        (51, "fifty one"),
        (52, "fifty two"),
        (53, "fifty three"),
        (54, "fifty four"),
        (55, "fifty five"),
        (56, "fifty six"),
        (57, "fifty seven"),
        (58, "fifty eight"),
        (59, "fifty nine"),
        (60, "sixty"),
        (61, "sixty one"),
        (62, "sixty two"),
        (63, "sixty three"),
        (64, "sixty four"),
        (65, "sixty five"),
        (66, "sixty six"),
        (67, "sixty seven"),
        (68, "sixty eight"),
        (69, "sixty nine"),
        (70, "seventy"),
        (71, "seventy one"),
        (72, "seventy two"),
        (73, "seventy three"),
        (74, "seventy four"),
        (75, "seventy five"),
        (76, "seventy six"),
        (77, "seventy seven"),
        (78, "seventy eight"),
        (79, "seventy nine"),
        (80, "eighty"),
        (81, "eighty one"),
        (82, "eighty two"),
        (83, "eighty three"),
        (84, "eighty four"),
        (85, "eighty five"),
        (86, "eighty six"),
        (87, "eighty seven"),
        (88, "eighty eight"),
        (89, "eighty nine"),
        (90, "ninety"),
        (91, "ninety one"),
        (92, "ninety two"),
        (93, "ninety three"),
        (94, "ninety four"),
        (95, "ninety five"),
        (96, "ninety six"),
        (97, "ninety seven"),
        (98, "ninety eight"),
        (99, "ninety nine")
    };

    private static IList<(decimal, string)> _100To999Source = new List<(decimal, string)>
    {
        (100, "one hundred"),
        (101, "one hundred and one"),
        (102, "one hundred and two"),
        (103, "one hundred and three"),
        (104, "one hundred and four"),
        (105, "one hundred and five"),
        (106, "one hundred and six"),
        (107, "one hundred and seven"),
        (108, "one hundred and eight"),
        (109, "one hundred and nine"),
        (110, "one hundred and ten"),
        (111, "one hundred and eleven"),
        (112, "one hundred and twelve"),
        (113, "one hundred and thirteen"),
        (114, "one hundred and fourteen"),
        (115, "one hundred and fifteen"),
        (116, "one hundred and sixteen"),
        (117, "one hundred and seventeen"),
        (118, "one hundred and eighteen"),
        (119, "one hundred and nineteen"),
        (120, "one hundred and twenty"),
        (121, "one hundred and twenty one"),
        (122, "one hundred and twenty two"),
        (123, "one hundred and twenty three"),
        (124, "one hundred and twenty four"),
        (125, "one hundred and twenty five"),
        (126, "one hundred and twenty six"),
        (127, "one hundred and twenty seven"),
        (128, "one hundred and twenty eight"),
        (129, "one hundred and twenty nine"),
        (130, "one hundred and thirty"),
        (131, "one hundred and thirty one"),
        (132, "one hundred and thirty two"),
        (133, "one hundred and thirty three"),
        (134, "one hundred and thirty four"),
        (135, "one hundred and thirty five"),
        (136, "one hundred and thirty six"),
        (137, "one hundred and thirty seven"),
        (138, "one hundred and thirty eight"),
        (139, "one hundred and thirty nine"),
        (140, "one hundred and forty"),
        (141, "one hundred and forty one"),
        (142, "one hundred and forty two"),
        (143, "one hundred and forty three"),
        (144, "one hundred and forty four"),
        (145, "one hundred and forty five"),
        (146, "one hundred and forty six"),
        (147, "one hundred and forty seven"),
        (148, "one hundred and forty eight"),
        (149, "one hundred and forty nine"),
        (150, "one hundred and fifty"),
        (151, "one hundred and fifty one"),
        (152, "one hundred and fifty two"),
        (153, "one hundred and fifty three"),
        (154, "one hundred and fifty four"),
        (155, "one hundred and fifty five"),
        (156, "one hundred and fifty six"),
        (157, "one hundred and fifty seven"),
        (158, "one hundred and fifty eight"),
        (261, "two hundred and sixty one"),
        (262, "two hundred and sixty two"),
        (263, "two hundred and sixty three"),
        (264, "two hundred and sixty four"),
        (265, "two hundred and sixty five"),
        (266, "two hundred and sixty six"),
        (267, "two hundred and sixty seven"),
        (268, "two hundred and sixty eight"),
        (269, "two hundred and sixty nine"),
        (270, "two hundred and seventy"),
        (271, "two hundred and seventy one"),
        (272, "two hundred and seventy two"),
        (273, "two hundred and seventy three"),
        (274, "two hundred and seventy four"),
        (275, "two hundred and seventy five"),
        (276, "two hundred and seventy six"),
        (277, "two hundred and seventy seven"),
        (278, "two hundred and seventy eight"),
        (279, "two hundred and seventy nine"),
        (280, "two hundred and eighty"),
        (281, "two hundred and eighty one"),
        (282, "two hundred and eighty two"),
        (283, "two hundred and eighty three"),
        (384, "three hundred and eighty four"),
        (385, "three hundred and eighty five"),
        (386, "three hundred and eighty six"),
        (387, "three hundred and eighty seven"),
        (388, "three hundred and eighty eight"),
        (389, "three hundred and eighty nine"),
        (390, "three hundred and ninety"),
        (391, "three hundred and ninety one"),
        (392, "three hundred and ninety two"),
        (493, "four hundred and ninety three"),
        (494, "four hundred and ninety four"),
        (495, "four hundred and ninety five"),
        (496, "four hundred and ninety six"),
        (497, "four hundred and ninety seven"),
        (498, "four hundred and ninety eight"),
        (499, "four hundred and ninety nine"),
        (500, "five hundred"),
        (632, "six hundred and thirty two"),
        (633, "six hundred and thirty three"),
        (634, "six hundred and thirty four"),
        (635, "six hundred and thirty five"),
        (636, "six hundred and thirty six"),
        (637, "six hundred and thirty seven"),
        (638, "six hundred and thirty eight"),
        (639, "six hundred and thirty nine"),
        (640, "six hundred and forty"),
        (641, "six hundred and forty one"),
        (642, "six hundred and forty two"),
        (643, "six hundred and forty three"),
        (644, "six hundred and forty four"),
        (645, "six hundred and forty five"),
        (646, "six hundred and forty six"),
        (647, "six hundred and forty seven"),
        (648, "six hundred and forty eight"),
        (649, "six hundred and forty nine"),
        (650, "six hundred and fifty"),
        (651, "six hundred and fifty one"),
        (652, "six hundred and fifty two"),
        (653, "six hundred and fifty three"),
        (654, "six hundred and fifty four"),
        (655, "six hundred and fifty five"),
        (656, "six hundred and fifty six"),
        (657, "six hundred and fifty seven"),
        (658, "six hundred and fifty eight"),
        (659, "six hundred and fifty nine"),
        (660, "six hundred and sixty"),
        (661, "six hundred and sixty one"),
        (662, "six hundred and sixty two"),
        (663, "six hundred and sixty three"),
        (664, "six hundred and sixty four"),
        (665, "six hundred and sixty five"),
        (666, "six hundred and sixty six"),
        (667, "six hundred and sixty seven"),
        (668, "six hundred and sixty eight"),
        (669, "six hundred and sixty nine"),
        (670, "six hundred and seventy"),
        (671, "six hundred and seventy one"),
        (672, "six hundred and seventy two"),
        (673, "six hundred and seventy three"),
        (674, "six hundred and seventy four"),
        (675, "six hundred and seventy five"),
        (676, "six hundred and seventy six"),
        (677, "six hundred and seventy seven"),
        (778, "seven hundred and seventy eight"),
        (779, "seven hundred and seventy nine"),
        (780, "seven hundred and eighty"),
        (781, "seven hundred and eighty one"),
        (782, "seven hundred and eighty two"),
        (783, "seven hundred and eighty three"),
        (784, "seven hundred and eighty four"),
        (785, "seven hundred and eighty five"),
        (786, "seven hundred and eighty six"),
        (787, "seven hundred and eighty seven"),
        (788, "seven hundred and eighty eight"),
        (789, "seven hundred and eighty nine"),
        (790, "seven hundred and ninety"),
        (791, "seven hundred and ninety one"),
        (792, "seven hundred and ninety two"),
        (793, "seven hundred and ninety three"),
        (794, "seven hundred and ninety four"),
        (795, "seven hundred and ninety five"),
        (796, "seven hundred and ninety six"),
        (797, "seven hundred and ninety seven"),
        (798, "seven hundred and ninety eight"),
        (799, "seven hundred and ninety nine"),
        (800, "eight hundred"),
        (801, "eight hundred and one"),
        (802, "eight hundred and two"),
        (803, "eight hundred and three"),
        (804, "eight hundred and four"),
        (805, "eight hundred and five"),
        (806, "eight hundred and six"),
        (807, "eight hundred and seven"),
        (808, "eight hundred and eight"),
        (809, "eight hundred and nine"),
        (810, "eight hundred and ten"),
        (811, "eight hundred and eleven"),
        (812, "eight hundred and twelve"),
        (813, "eight hundred and thirteen"),
        (814, "eight hundred and fourteen"),
        (815, "eight hundred and fifteen"),
        (816, "eight hundred and sixteen"),
        (817, "eight hundred and seventeen"),
        (818, "eight hundred and eighteen"),
        (819, "eight hundred and nineteen"),
        (820, "eight hundred and twenty"),
        (821, "eight hundred and twenty one"),
        (822, "eight hundred and twenty two"),
        (823, "eight hundred and twenty three"),
        (824, "eight hundred and twenty four"),
        (825, "eight hundred and twenty five"),
        (959, "nine hundred and fifty nine"),
        (960, "nine hundred and sixty"),
        (961, "nine hundred and sixty one"),
        (962, "nine hundred and sixty two"),
        (963, "nine hundred and sixty three"),
        (964, "nine hundred and sixty four"),
        (965, "nine hundred and sixty five"),
        (966, "nine hundred and sixty six"),
        (967, "nine hundred and sixty seven"),
        (968, "nine hundred and sixty eight"),
        (969, "nine hundred and sixty nine"),
        (970, "nine hundred and seventy"),
        (971, "nine hundred and seventy one"),
        (972, "nine hundred and seventy two"),
        (973, "nine hundred and seventy three"),
        (974, "nine hundred and seventy four"),
        (975, "nine hundred and seventy five"),
        (976, "nine hundred and seventy six"),
        (977, "nine hundred and seventy seven"),
        (978, "nine hundred and seventy eight"),
        (979, "nine hundred and seventy nine"),
        (980, "nine hundred and eighty"),
        (981, "nine hundred and eighty one"),
        (982, "nine hundred and eighty two"),
        (983, "nine hundred and eighty three"),
        (984, "nine hundred and eighty four"),
        (985, "nine hundred and eighty five"),
        (986, "nine hundred and eighty six"),
        (987, "nine hundred and eighty seven"),
        (988, "nine hundred and eighty eight"),
        (989, "nine hundred and eighty nine"),
        (990, "nine hundred and ninety"),
        (991, "nine hundred and ninety one"),
        (992, "nine hundred and ninety two"),
        (993, "nine hundred and ninety three"),
        (994, "nine hundred and ninety four"),
        (995, "nine hundred and ninety five"),
        (996, "nine hundred and ninety six"),
        (997, "nine hundred and ninety seven"),
        (998, "nine hundred and ninety eight"),
        (999, "nine hundred and ninety nine")
    };

    private static IList<(decimal, string)> _1000To9999Source = new List<(decimal, string)>
    {
        //a few random values from 1000 to 999999
        (1001, "one thousand and one"),
        (1002, "one thousand and two"),
        (1003, "one thousand and three"),
        (1004, "one thousand and four"),
        (1005, "one thousand and five"),
        (1006, "one thousand and six"),
        (1007, "one thousand and seven"),
        (1008, "one thousand and eight"),
        (1009, "one thousand and nine"),
        (1010, "one thousand and ten"),
        (1011, "one thousand and eleven"),
        (1012, "one thousand and twelve"),
        (1013, "one thousand and thirteen"),
        (1014, "one thousand and fourteen"),
        (1015, "one thousand and fifteen"),
        (1016, "one thousand and sixteen"),
        (1017, "one thousand and seventeen"),
        (1018, "one thousand and eighteen"),
        (1019, "one thousand and nineteen"),
        (1020, "one thousand and twenty"),
        (1021, "one thousand and twenty one"),
        (1022, "one thousand and twenty two"),
        (1023, "one thousand and twenty three"),
        (1024, "one thousand and twenty four"),
        (1025, "one thousand and twenty five"),
        (2434, "two thousand four hundred and thirty four"),
        (2435, "two thousand four hundred and thirty five"),
        (2436, "two thousand four hundred and thirty six"),
        (2437, "two thousand four hundred and thirty seven"),
        (2438, "two thousand four hundred and thirty eight"),
        (2439, "two thousand four hundred and thirty nine"),
        (2440, "two thousand four hundred and forty"),
        (2441, "two thousand four hundred and forty one"),
        (2442, "two thousand four hundred and forty two"),
        (2443, "two thousand four hundred and forty three"),
        (2444, "two thousand four hundred and forty four"),
        (2445, "two thousand four hundred and forty five"),
        (2446, "two thousand four hundred and forty six"),
        (2447, "two thousand four hundred and forty seven"),
        (2448, "two thousand four hundred and forty eight"),
        (2449, "two thousand four hundred and forty nine"),
        (2450, "two thousand four hundred and fifty"),
        (2451, "two thousand four hundred and fifty one"),
        (2452, "two thousand four hundred and fifty two"),
        (2453, "two thousand four hundred and fifty three"),
        (2454, "two thousand four hundred and fifty four"),
        (2455, "two thousand four hundred and fifty five"),
        (2456, "two thousand four hundred and fifty six"),
        (2457, "two thousand four hundred and fifty seven"),
        (2458, "two thousand four hundred and fifty eight"),
        (2459, "two thousand four hundred and fifty nine"),
        (2460, "two thousand four hundred and sixty"),
        (2461, "two thousand four hundred and sixty one"),
        (2462, "two thousand four hundred and sixty two"),
        (2463, "two thousand four hundred and sixty three"),
        (2464, "two thousand four hundred and sixty four"),
        (2465, "two thousand four hundred and sixty five"),
        (2466, "two thousand four hundred and sixty six"),
        (2467, "two thousand four hundred and sixty seven"),
        (2468, "two thousand four hundred and sixty eight"),
        (2469, "two thousand four hundred and sixty nine"),
        (3650, "three thousand six hundred and fifty"),
        (3651, "three thousand six hundred and fifty one"),
        (3652, "three thousand six hundred and fifty two"),
        (3653, "three thousand six hundred and fifty three"),
        (3654, "three thousand six hundred and fifty four"),
        (3655, "three thousand six hundred and fifty five"),
        (3656, "three thousand six hundred and fifty six"),
        (3657, "three thousand six hundred and fifty seven"),
        (3658, "three thousand six hundred and fifty eight"),
        (3659, "three thousand six hundred and fifty nine"),
        (3660, "three thousand six hundred and sixty"),
        (3661, "three thousand six hundred and sixty one"),
        (3662, "three thousand six hundred and sixty two"),
        (3663, "three thousand six hundred and sixty three"),
        (3664, "three thousand six hundred and sixty four"),
        (3665, "three thousand six hundred and sixty five"),
        (3666, "three thousand six hundred and sixty six"),
        (3667, "three thousand six hundred and sixty seven"),
        (3668, "three thousand six hundred and sixty eight"),
        (3669, "three thousand six hundred and sixty nine"),
        (3670, "three thousand six hundred and seventy"),
        (3671, "three thousand six hundred and seventy one"),
        (3672, "three thousand six hundred and seventy two"),
        (3673, "three thousand six hundred and seventy three"),
        (3674, "three thousand six hundred and seventy four"),
        (3675, "three thousand six hundred and seventy five"),
        (3676, "three thousand six hundred and seventy six"),
        (3677, "three thousand six hundred and seventy seven"),
        (3678, "three thousand six hundred and seventy eight"),
        (3679, "three thousand six hundred and seventy nine"),
        (3680, "three thousand six hundred and eighty"),
        (3681, "three thousand six hundred and eighty one"),
        (3682, "three thousand six hundred and eighty two"),
        (3683, "three thousand six hundred and eighty three"),
        (3684, "three thousand six hundred and eighty four"),
        (3685, "three thousand six hundred and eighty five"),
        (4754, "four thousand seven hundred and fifty four"),
        (4755, "four thousand seven hundred and fifty five"),
        (4756, "four thousand seven hundred and fifty six"),
        (4757, "four thousand seven hundred and fifty seven"),
        (4758, "four thousand seven hundred and fifty eight"),
        (4759, "four thousand seven hundred and fifty nine"),
        (4760, "four thousand seven hundred and sixty"),
        (4761, "four thousand seven hundred and sixty one"),
        (4762, "four thousand seven hundred and sixty two"),
        (4763, "four thousand seven hundred and sixty three"),
        (4764, "four thousand seven hundred and sixty four"),
        (4765, "four thousand seven hundred and sixty five"),
        (4766, "four thousand seven hundred and sixty six"),
        (4767, "four thousand seven hundred and sixty seven"),
        (4768, "four thousand seven hundred and sixty eight"),
        (4769, "four thousand seven hundred and sixty nine"),
        (4770, "four thousand seven hundred and seventy"),
        (4771, "four thousand seven hundred and seventy one"),
        (4772, "four thousand seven hundred and seventy two"),
        (4773, "four thousand seven hundred and seventy three"),
        (4774, "four thousand seven hundred and seventy four"),
        (4775, "four thousand seven hundred and seventy five"),
        (4776, "four thousand seven hundred and seventy six"),
        (4777, "four thousand seven hundred and seventy seven"),
        (4778, "four thousand seven hundred and seventy eight"),
        (4779, "four thousand seven hundred and seventy nine"),
        (4780, "four thousand seven hundred and eighty"),
        (4781, "four thousand seven hundred and eighty one"),
        (4782, "four thousand seven hundred and eighty two"),
        (4783, "four thousand seven hundred and eighty three"),
        (4784, "four thousand seven hundred and eighty four"),
        (4785, "four thousand seven hundred and eighty five"),
        (4786, "four thousand seven hundred and eighty six"),
        (4787, "four thousand seven hundred and eighty seven"),
        (4788, "four thousand seven hundred and eighty eight"),
        (4789, "four thousand seven hundred and eighty nine"),
        (5890,  "five thousand eight hundred and ninety"),
        (5891,  "five thousand eight hundred and ninety one"),
        (6992,  "six thousand nine hundred and ninety two"),
        (6993,  "six thousand nine hundred and ninety three"),
        (6994,  "six thousand nine hundred and ninety four"),
        (6995,  "six thousand nine hundred and ninety five"),
        (6996,  "six thousand nine hundred and ninety six"),
        (6997,  "six thousand nine hundred and ninety seven"),
        (6998,  "six thousand nine hundred and ninety eight"),
        (6999,  "six thousand nine hundred and ninety nine"),
        (7000,  "seven thousand"),
        (7001,  "seven thousand and one"),
        (7002,  "seven thousand and two"),
        (7003,  "seven thousand and three"),
        (7004,  "seven thousand and four"),
        (7005,  "seven thousand and five"),
        (7006,  "seven thousand and six"),
        (7007,  "seven thousand and seven"),
        (7008,  "seven thousand and eight"),
        (7009,  "seven thousand and nine"),
        (7010,  "seven thousand and ten"),
        (7011,  "seven thousand and eleven"),
        (7012,  "seven thousand and twelve"),
        (7013,  "seven thousand and thirteen"),
        (7014,  "seven thousand and fourteen"),
        (7015,  "seven thousand and fifteen"),
        (7016,  "seven thousand and sixteen"),
        (7017,  "seven thousand and seventeen"),
        (7018,  "seven thousand and eighteen"),
        (7019,  "seven thousand and nineteen"),
        (7020,  "seven thousand and twenty"),
        (7021,  "seven thousand and twenty one"),
        (7022,  "seven thousand and twenty two"),
        (7023,  "seven thousand and twenty three"),
        (7024,  "seven thousand and twenty four"),
        (7025,  "seven thousand and twenty five"),
        (7026,  "seven thousand and twenty six"),
        (7027,  "seven thousand and twenty seven"),
        (7028,  "seven thousand and twenty eight"),
        (7029,  "seven thousand and twenty nine"),
        (7030,  "seven thousand and thirty"),
        (8531,  "eight thousand five hundred and thirty one"),
        (8532,  "eight thousand five hundred and thirty two"),
        (8533,  "eight thousand five hundred and thirty three"),
        (8534,  "eight thousand five hundred and thirty four"),
        (8535,  "eight thousand five hundred and thirty five"),
        (8536,  "eight thousand five hundred and thirty six"),
        (8537,  "eight thousand five hundred and thirty seven"),
        (8538,  "eight thousand five hundred and thirty eight"),
        (8539,  "eight thousand five hundred and thirty nine"),
        (8540,  "eight thousand five hundred and forty"),
        (8541,  "eight thousand five hundred and forty one"),
        (8542,  "eight thousand five hundred and forty two"),
        (8543,  "eight thousand five hundred and forty three"),
        (8544,  "eight thousand five hundred and forty four"),
        (8545,  "eight thousand five hundred and forty five"),
        (8546,  "eight thousand five hundred and forty six"),
        (8547,  "eight thousand five hundred and forty seven"),
        (8548,  "eight thousand five hundred and forty eight"),
        (8549,  "eight thousand five hundred and forty nine"),
        (8550,  "eight thousand five hundred and fifty"),
        (8551,  "eight thousand five hundred and fifty one"),
        (8552,  "eight thousand five hundred and fifty two"),
        (9553,  "nine thousand five hundred and fifty three"),
        (9554,  "nine thousand five hundred and fifty four"),
        (9555,  "nine thousand five hundred and fifty five"),
        (9556,  "nine thousand five hundred and fifty six"),
        (9557,  "nine thousand five hundred and fifty seven"),
        (9558,  "nine thousand five hundred and fifty eight"),
        (9559,  "nine thousand five hundred and fifty nine"),
        (9560,  "nine thousand five hundred and sixty"),
        (9561,  "nine thousand five hundred and sixty one"),
        (9562,  "nine thousand five hundred and sixty two"),
        (9563,  "nine thousand five hundred and sixty three"),
        (9564,  "nine thousand five hundred and sixty four"),
        (9565,  "nine thousand five hundred and sixty five"),
        (9566,  "nine thousand five hundred and sixty six"),
        (9567,  "nine thousand five hundred and sixty seven"),
        (9568,  "nine thousand five hundred and sixty eight"),
        (9569,  "nine thousand five hundred and sixty nine"),
        (9570,  "nine thousand five hundred and seventy"),
        (9571,  "nine thousand five hundred and seventy one"),
        (9572,  "nine thousand five hundred and seventy two"),
        (9573,  "nine thousand five hundred and seventy three"),
        (9574,  "nine thousand five hundred and seventy four"),
        (9575,  "nine thousand five hundred and seventy five"),
        (9576,  "nine thousand five hundred and seventy six"),
        (9577,  "nine thousand five hundred and seventy seven"),
        (9578,  "nine thousand five hundred and seventy eight"),
        (9579,  "nine thousand five hundred and seventy nine"),
        (9580,  "nine thousand five hundred and eighty"),
        (9581,  "nine thousand five hundred and eighty one"),
        (9582,  "nine thousand five hundred and eighty two"),
        (9583,  "nine thousand five hundred and eighty three"),
        (9584,  "nine thousand five hundred and eighty four"),
        (9585,  "nine thousand five hundred and eighty five"),
        (9586,  "nine thousand five hundred and eighty six"),
        (9999,  "nine thousand nine hundred and ninety nine"),
    };
}