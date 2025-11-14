using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T403 - .
/// </summary>
public class F75T403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D3CO.
        /// </summary>
        public const string D3CO = "D3CO";

        /// <summary>
        /// D375TDSI.
        /// </summary>
        public const string D375TDSI = "D375TDSI";

        /// <summary>
        /// D375TYMD.
        /// </summary>
        public const string D375TYMD = "D375TYMD";

        /// <summary>
        /// D3PSQ.
        /// </summary>
        public const string D3PSQ = "D3PSQ";

        /// <summary>
        /// D375TVID.
        /// </summary>
        public const string D375TVID = "D375TVID";

        /// <summary>
        /// D375TYMS.
        /// </summary>
        public const string D375TYMS = "D375TYMS";

        /// <summary>
        /// D375TYMT.
        /// </summary>
        public const string D375TYMT = "D375TYMT";

        /// <summary>
        /// D375TDBM.
        /// </summary>
        public const string D375TDBM = "D375TDBM";

        /// <summary>
        /// D375TMDU.
        /// </summary>
        public const string D375TMDU = "D375TMDU";

        /// <summary>
        /// D375TTRM.
        /// </summary>
        public const string D375TTRM = "D375TTRM";

        /// <summary>
        /// D375TUIC.
        /// </summary>
        public const string D375TUIC = "D375TUIC";

        /// <summary>
        /// D375TGDC.
        /// </summary>
        public const string D375TGDC = "D375TGDC";

        /// <summary>
        /// D375TPDC.
        /// </summary>
        public const string D375TPDC = "D375TPDC";

        /// <summary>
        /// D375TCVC.
        /// </summary>
        public const string D375TCVC = "D375TCVC";

        /// <summary>
        /// D375TRAC.
        /// </summary>
        public const string D375TRAC = "D375TRAC";

        /// <summary>
        /// D375TPFC.
        /// </summary>
        public const string D375TPFC = "D375TPFC";

        /// <summary>
        /// D375TZDC.
        /// </summary>
        public const string D375TZDC = "D375TZDC";

        /// <summary>
        /// D375TTDD.
        /// </summary>
        public const string D375TTDD = "D375TTDD";

        /// <summary>
        /// D375T001.
        /// </summary>
        public const string D375T001 = "D375T001";

        /// <summary>
        /// D375T002.
        /// </summary>
        public const string D375T002 = "D375T002";

        /// <summary>
        /// D375T005.
        /// </summary>
        public const string D375T005 = "D375T005";

        /// <summary>
        /// D375T006.
        /// </summary>
        public const string D375T006 = "D375T006";

        /// <summary>
        /// D375T009.
        /// </summary>
        public const string D375T009 = "D375T009";

        /// <summary>
        /// D375T010.
        /// </summary>
        public const string D375T010 = "D375T010";

        /// <summary>
        /// D375T013.
        /// </summary>
        public const string D375T013 = "D375T013";

        /// <summary>
        /// D375T014.
        /// </summary>
        public const string D375T014 = "D375T014";

        /// <summary>
        /// D375T017.
        /// </summary>
        public const string D375T017 = "D375T017";

        /// <summary>
        /// D375T018.
        /// </summary>
        public const string D375T018 = "D375T018";

        /// <summary>
        /// D375T021.
        /// </summary>
        public const string D375T021 = "D375T021";

        /// <summary>
        /// D375T022.
        /// </summary>
        public const string D375T022 = "D375T022";

        /// <summary>
        /// D375T003.
        /// </summary>
        public const string D375T003 = "D375T003";

        /// <summary>
        /// D375T007.
        /// </summary>
        public const string D375T007 = "D375T007";

        /// <summary>
        /// D375T011.
        /// </summary>
        public const string D375T011 = "D375T011";

        /// <summary>
        /// D375T015.
        /// </summary>
        public const string D375T015 = "D375T015";

        /// <summary>
        /// D375T019.
        /// </summary>
        public const string D375T019 = "D375T019";

        /// <summary>
        /// D375T023.
        /// </summary>
        public const string D375T023 = "D375T023";

        /// <summary>
        /// D375T004.
        /// </summary>
        public const string D375T004 = "D375T004";

        /// <summary>
        /// D375T008.
        /// </summary>
        public const string D375T008 = "D375T008";

        /// <summary>
        /// D375T012.
        /// </summary>
        public const string D375T012 = "D375T012";

        /// <summary>
        /// D375T016.
        /// </summary>
        public const string D375T016 = "D375T016";

        /// <summary>
        /// D375T020.
        /// </summary>
        public const string D375T020 = "D375T020";

        /// <summary>
        /// D375T024.
        /// </summary>
        public const string D375T024 = "D375T024";

        /// <summary>
        /// D375T052.
        /// </summary>
        public const string D375T052 = "D375T052";

        /// <summary>
        /// D375T053.
        /// </summary>
        public const string D375T053 = "D375T053";

        /// <summary>
        /// D375T054.
        /// </summary>
        public const string D375T054 = "D375T054";

        /// <summary>
        /// D375T055.
        /// </summary>
        public const string D375T055 = "D375T055";

        /// <summary>
        /// D375T056.
        /// </summary>
        public const string D375T056 = "D375T056";

        /// <summary>
        /// D375T057.
        /// </summary>
        public const string D375T057 = "D375T057";

        /// <summary>
        /// D375T058.
        /// </summary>
        public const string D375T058 = "D375T058";

        /// <summary>
        /// D375T059.
        /// </summary>
        public const string D375T059 = "D375T059";

        /// <summary>
        /// D375T060.
        /// </summary>
        public const string D375T060 = "D375T060";

        /// <summary>
        /// D375T061.
        /// </summary>
        public const string D375T061 = "D375T061";

        /// <summary>
        /// D375T062.
        /// </summary>
        public const string D375T062 = "D375T062";

        /// <summary>
        /// D375T063.
        /// </summary>
        public const string D375T063 = "D375T063";

        /// <summary>
        /// D375T064.
        /// </summary>
        public const string D375T064 = "D375T064";

        /// <summary>
        /// D375T065.
        /// </summary>
        public const string D375T065 = "D375T065";

        /// <summary>
        /// D375T066.
        /// </summary>
        public const string D375T066 = "D375T066";

        /// <summary>
        /// D375T025.
        /// </summary>
        public const string D375T025 = "D375T025";

        /// <summary>
        /// D375T026.
        /// </summary>
        public const string D375T026 = "D375T026";

        /// <summary>
        /// D375T027.
        /// </summary>
        public const string D375T027 = "D375T027";

        /// <summary>
        /// D375T028.
        /// </summary>
        public const string D375T028 = "D375T028";

        /// <summary>
        /// D375T029.
        /// </summary>
        public const string D375T029 = "D375T029";

        /// <summary>
        /// D375T030.
        /// </summary>
        public const string D375T030 = "D375T030";

        /// <summary>
        /// D375T031.
        /// </summary>
        public const string D375T031 = "D375T031";

        /// <summary>
        /// D375T032.
        /// </summary>
        public const string D375T032 = "D375T032";

        /// <summary>
        /// D375T033.
        /// </summary>
        public const string D375T033 = "D375T033";

        /// <summary>
        /// D375T034.
        /// </summary>
        public const string D375T034 = "D375T034";

        /// <summary>
        /// D375T035.
        /// </summary>
        public const string D375T035 = "D375T035";

        /// <summary>
        /// D375T036.
        /// </summary>
        public const string D375T036 = "D375T036";

        /// <summary>
        /// D375T037.
        /// </summary>
        public const string D375T037 = "D375T037";

        /// <summary>
        /// D375T038.
        /// </summary>
        public const string D375T038 = "D375T038";

        /// <summary>
        /// D375T039.
        /// </summary>
        public const string D375T039 = "D375T039";

        /// <summary>
        /// D375T078.
        /// </summary>
        public const string D375T078 = "D375T078";

        /// <summary>
        /// D375T079.
        /// </summary>
        public const string D375T079 = "D375T079";

        /// <summary>
        /// D375T080.
        /// </summary>
        public const string D375T080 = "D375T080";

        /// <summary>
        /// D375T081.
        /// </summary>
        public const string D375T081 = "D375T081";

        /// <summary>
        /// D375T040.
        /// </summary>
        public const string D375T040 = "D375T040";

        /// <summary>
        /// D375T041.
        /// </summary>
        public const string D375T041 = "D375T041";

        /// <summary>
        /// D375T042.
        /// </summary>
        public const string D375T042 = "D375T042";

        /// <summary>
        /// D375T043.
        /// </summary>
        public const string D375T043 = "D375T043";

        /// <summary>
        /// D375T044.
        /// </summary>
        public const string D375T044 = "D375T044";

        /// <summary>
        /// D375T045.
        /// </summary>
        public const string D375T045 = "D375T045";

        /// <summary>
        /// D375T046.
        /// </summary>
        public const string D375T046 = "D375T046";

        /// <summary>
        /// D375T047.
        /// </summary>
        public const string D375T047 = "D375T047";

        /// <summary>
        /// D375T048.
        /// </summary>
        public const string D375T048 = "D375T048";

        /// <summary>
        /// D375T049.
        /// </summary>
        public const string D375T049 = "D375T049";

        /// <summary>
        /// D375T050.
        /// </summary>
        public const string D375T050 = "D375T050";

        /// <summary>
        /// D375T051.
        /// </summary>
        public const string D375T051 = "D375T051";

        /// <summary>
        /// D375T067.
        /// </summary>
        public const string D375T067 = "D375T067";

        /// <summary>
        /// D375T068.
        /// </summary>
        public const string D375T068 = "D375T068";

        /// <summary>
        /// D375T069.
        /// </summary>
        public const string D375T069 = "D375T069";

        /// <summary>
        /// D375T070.
        /// </summary>
        public const string D375T070 = "D375T070";

        /// <summary>
        /// D375T071.
        /// </summary>
        public const string D375T071 = "D375T071";

        /// <summary>
        /// D375T072.
        /// </summary>
        public const string D375T072 = "D375T072";

        /// <summary>
        /// D375T073.
        /// </summary>
        public const string D375T073 = "D375T073";

        /// <summary>
        /// D375T074.
        /// </summary>
        public const string D375T074 = "D375T074";

        /// <summary>
        /// D375T075.
        /// </summary>
        public const string D375T075 = "D375T075";

        /// <summary>
        /// D375T076.
        /// </summary>
        public const string D375T076 = "D375T076";

        /// <summary>
        /// D375T101.
        /// </summary>
        public const string D375T101 = "D375T101";

        /// <summary>
        /// D375T102.
        /// </summary>
        public const string D375T102 = "D375T102";

        /// <summary>
        /// D375T103.
        /// </summary>
        public const string D375T103 = "D375T103";

        /// <summary>
        /// D375T104.
        /// </summary>
        public const string D375T104 = "D375T104";

        /// <summary>
        /// D375T105.
        /// </summary>
        public const string D375T105 = "D375T105";

        /// <summary>
        /// D375T106.
        /// </summary>
        public const string D375T106 = "D375T106";

        /// <summary>
        /// D375T107.
        /// </summary>
        public const string D375T107 = "D375T107";

        /// <summary>
        /// D375T108.
        /// </summary>
        public const string D375T108 = "D375T108";

        /// <summary>
        /// D375T109.
        /// </summary>
        public const string D375T109 = "D375T109";

        /// <summary>
        /// D375T110.
        /// </summary>
        public const string D375T110 = "D375T110";

        /// <summary>
        /// D375T111.
        /// </summary>
        public const string D375T111 = "D375T111";

        /// <summary>
        /// D375T112.
        /// </summary>
        public const string D375T112 = "D375T112";

        /// <summary>
        /// D375T113.
        /// </summary>
        public const string D375T113 = "D375T113";

        /// <summary>
        /// D375T114.
        /// </summary>
        public const string D375T114 = "D375T114";

        /// <summary>
        /// D375T115.
        /// </summary>
        public const string D375T115 = "D375T115";

        /// <summary>
        /// D375T082.
        /// </summary>
        public const string D375T082 = "D375T082";

        /// <summary>
        /// D375TGES.
        /// </summary>
        public const string D375TGES = "D375TGES";

        /// <summary>
        /// D3URC1.
        /// </summary>
        public const string D3URC1 = "D3URC1";

        /// <summary>
        /// D3URDT.
        /// </summary>
        public const string D3URDT = "D3URDT";

        /// <summary>
        /// D3URAT.
        /// </summary>
        public const string D3URAT = "D3URAT";

        /// <summary>
        /// D3URAB.
        /// </summary>
        public const string D3URAB = "D3URAB";

        /// <summary>
        /// D3URRF.
        /// </summary>
        public const string D3URRF = "D3URRF";

        /// <summary>
        /// D3USER.
        /// </summary>
        public const string D3USER = "D3USER";

        /// <summary>
        /// D3PID.
        /// </summary>
        public const string D3PID = "D3PID";

        /// <summary>
        /// D3JOBN.
        /// </summary>
        public const string D3JOBN = "D3JOBN";

        /// <summary>
        /// D3UPMJ.
        /// </summary>
        public const string D3UPMJ = "D3UPMJ";

        /// <summary>
        /// D3TDAY.
        /// </summary>
        public const string D3TDAY = "D3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D3CO", "D3CO", JdeDataType.String, 10, true, true),
        new JdeField("D375TDSI", "D375TDSI", JdeDataType.String, 10, true, true),
        new JdeField("D375TYMD", "D375TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("D3PSQ", "D3PSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D375TVID", "D375TVID", JdeDataType.String, 2),
        new JdeField("D375TYMS", "D375TYMS", JdeDataType.Numeric),
        new JdeField("D375TYMT", "D375TYMT", JdeDataType.Numeric),
        new JdeField("D375TDBM", "D375TDBM", JdeDataType.String, 2),
        new JdeField("D375TMDU", "D375TMDU", JdeDataType.String, 4),
        new JdeField("D375TTRM", "D375TTRM", JdeDataType.String, 6),
        new JdeField("D375TUIC", "D375TUIC", JdeDataType.Numeric),
        new JdeField("D375TGDC", "D375TGDC", JdeDataType.Numeric),
        new JdeField("D375TPDC", "D375TPDC", JdeDataType.Numeric),
        new JdeField("D375TCVC", "D375TCVC", JdeDataType.Numeric),
        new JdeField("D375TRAC", "D375TRAC", JdeDataType.Numeric),
        new JdeField("D375TPFC", "D375TPFC", JdeDataType.Numeric),
        new JdeField("D375TZDC", "D375TZDC", JdeDataType.Numeric),
        new JdeField("D375TTDD", "D375TTDD", JdeDataType.Numeric),
        new JdeField("D375T001", "D375T001", JdeDataType.Numeric),
        new JdeField("D375T002", "D375T002", JdeDataType.Numeric),
        new JdeField("D375T005", "D375T005", JdeDataType.Numeric),
        new JdeField("D375T006", "D375T006", JdeDataType.Numeric),
        new JdeField("D375T009", "D375T009", JdeDataType.Numeric),
        new JdeField("D375T010", "D375T010", JdeDataType.Numeric),
        new JdeField("D375T013", "D375T013", JdeDataType.Numeric),
        new JdeField("D375T014", "D375T014", JdeDataType.Numeric),
        new JdeField("D375T017", "D375T017", JdeDataType.Numeric),
        new JdeField("D375T018", "D375T018", JdeDataType.Numeric),
        new JdeField("D375T021", "D375T021", JdeDataType.Numeric),
        new JdeField("D375T022", "D375T022", JdeDataType.Numeric),
        new JdeField("D375T003", "D375T003", JdeDataType.Numeric),
        new JdeField("D375T007", "D375T007", JdeDataType.Numeric),
        new JdeField("D375T011", "D375T011", JdeDataType.Numeric),
        new JdeField("D375T015", "D375T015", JdeDataType.Numeric),
        new JdeField("D375T019", "D375T019", JdeDataType.Numeric),
        new JdeField("D375T023", "D375T023", JdeDataType.Numeric),
        new JdeField("D375T004", "D375T004", JdeDataType.Numeric),
        new JdeField("D375T008", "D375T008", JdeDataType.Numeric),
        new JdeField("D375T012", "D375T012", JdeDataType.Numeric),
        new JdeField("D375T016", "D375T016", JdeDataType.Numeric),
        new JdeField("D375T020", "D375T020", JdeDataType.Numeric),
        new JdeField("D375T024", "D375T024", JdeDataType.Numeric),
        new JdeField("D375T052", "D375T052", JdeDataType.Numeric),
        new JdeField("D375T053", "D375T053", JdeDataType.Numeric),
        new JdeField("D375T054", "D375T054", JdeDataType.Numeric),
        new JdeField("D375T055", "D375T055", JdeDataType.Numeric),
        new JdeField("D375T056", "D375T056", JdeDataType.Numeric),
        new JdeField("D375T057", "D375T057", JdeDataType.Numeric),
        new JdeField("D375T058", "D375T058", JdeDataType.Numeric),
        new JdeField("D375T059", "D375T059", JdeDataType.Numeric),
        new JdeField("D375T060", "D375T060", JdeDataType.Numeric),
        new JdeField("D375T061", "D375T061", JdeDataType.Numeric),
        new JdeField("D375T062", "D375T062", JdeDataType.Numeric),
        new JdeField("D375T063", "D375T063", JdeDataType.Numeric),
        new JdeField("D375T064", "D375T064", JdeDataType.Numeric),
        new JdeField("D375T065", "D375T065", JdeDataType.Numeric),
        new JdeField("D375T066", "D375T066", JdeDataType.Numeric),
        new JdeField("D375T025", "D375T025", JdeDataType.Numeric),
        new JdeField("D375T026", "D375T026", JdeDataType.Numeric),
        new JdeField("D375T027", "D375T027", JdeDataType.Numeric),
        new JdeField("D375T028", "D375T028", JdeDataType.Numeric),
        new JdeField("D375T029", "D375T029", JdeDataType.Numeric),
        new JdeField("D375T030", "D375T030", JdeDataType.Numeric),
        new JdeField("D375T031", "D375T031", JdeDataType.Numeric),
        new JdeField("D375T032", "D375T032", JdeDataType.Numeric),
        new JdeField("D375T033", "D375T033", JdeDataType.Numeric),
        new JdeField("D375T034", "D375T034", JdeDataType.Numeric),
        new JdeField("D375T035", "D375T035", JdeDataType.Numeric),
        new JdeField("D375T036", "D375T036", JdeDataType.Numeric),
        new JdeField("D375T037", "D375T037", JdeDataType.Numeric),
        new JdeField("D375T038", "D375T038", JdeDataType.Numeric),
        new JdeField("D375T039", "D375T039", JdeDataType.Numeric),
        new JdeField("D375T078", "D375T078", JdeDataType.Numeric),
        new JdeField("D375T079", "D375T079", JdeDataType.Numeric),
        new JdeField("D375T080", "D375T080", JdeDataType.Numeric),
        new JdeField("D375T081", "D375T081", JdeDataType.Numeric),
        new JdeField("D375T040", "D375T040", JdeDataType.Numeric),
        new JdeField("D375T041", "D375T041", JdeDataType.Numeric),
        new JdeField("D375T042", "D375T042", JdeDataType.Numeric),
        new JdeField("D375T043", "D375T043", JdeDataType.Numeric),
        new JdeField("D375T044", "D375T044", JdeDataType.Numeric),
        new JdeField("D375T045", "D375T045", JdeDataType.Numeric),
        new JdeField("D375T046", "D375T046", JdeDataType.Numeric),
        new JdeField("D375T047", "D375T047", JdeDataType.Numeric),
        new JdeField("D375T048", "D375T048", JdeDataType.Numeric),
        new JdeField("D375T049", "D375T049", JdeDataType.Numeric),
        new JdeField("D375T050", "D375T050", JdeDataType.Numeric),
        new JdeField("D375T051", "D375T051", JdeDataType.Numeric),
        new JdeField("D375T067", "D375T067", JdeDataType.Numeric),
        new JdeField("D375T068", "D375T068", JdeDataType.Numeric),
        new JdeField("D375T069", "D375T069", JdeDataType.Numeric),
        new JdeField("D375T070", "D375T070", JdeDataType.Numeric),
        new JdeField("D375T071", "D375T071", JdeDataType.Numeric),
        new JdeField("D375T072", "D375T072", JdeDataType.Numeric),
        new JdeField("D375T073", "D375T073", JdeDataType.Numeric),
        new JdeField("D375T074", "D375T074", JdeDataType.Numeric),
        new JdeField("D375T075", "D375T075", JdeDataType.Numeric),
        new JdeField("D375T076", "D375T076", JdeDataType.Numeric),
        new JdeField("D375T101", "D375T101", JdeDataType.Numeric),
        new JdeField("D375T102", "D375T102", JdeDataType.Numeric),
        new JdeField("D375T103", "D375T103", JdeDataType.Numeric),
        new JdeField("D375T104", "D375T104", JdeDataType.Numeric),
        new JdeField("D375T105", "D375T105", JdeDataType.Numeric),
        new JdeField("D375T106", "D375T106", JdeDataType.Numeric),
        new JdeField("D375T107", "D375T107", JdeDataType.Numeric),
        new JdeField("D375T108", "D375T108", JdeDataType.Numeric),
        new JdeField("D375T109", "D375T109", JdeDataType.Numeric),
        new JdeField("D375T110", "D375T110", JdeDataType.Numeric),
        new JdeField("D375T111", "D375T111", JdeDataType.Numeric),
        new JdeField("D375T112", "D375T112", JdeDataType.Numeric),
        new JdeField("D375T113", "D375T113", JdeDataType.Numeric),
        new JdeField("D375T114", "D375T114", JdeDataType.Numeric),
        new JdeField("D375T115", "D375T115", JdeDataType.Numeric),
        new JdeField("D375T082", "D375T082", JdeDataType.Numeric),
        new JdeField("D375TGES", "D375TGES", JdeDataType.Numeric),
        new JdeField("D3URC1", "D3URC1", JdeDataType.String, 6),
        new JdeField("D3URDT", "D3URDT", JdeDataType.Numeric),
        new JdeField("D3URAT", "D3URAT", JdeDataType.Numeric),
        new JdeField("D3URAB", "D3URAB", JdeDataType.Numeric),
        new JdeField("D3URRF", "D3URRF", JdeDataType.String, 30),
        new JdeField("D3USER", "D3USER", JdeDataType.String, 20),
        new JdeField("D3PID", "D3PID", JdeDataType.String, 20),
        new JdeField("D3JOBN", "D3JOBN", JdeDataType.String, 20),
        new JdeField("D3UPMJ", "D3UPMJ", JdeDataType.Numeric),
        new JdeField("D3TDAY", "D3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T403_0", "Primary Key on D3CO, D375TDSI, D375TYMD, D3PSQ", new[] { "D3CO", "D375TDSI", "D375TYMD", "D3PSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T403_2", "Index on D3CO, D375TDSI, D375TYMD, SYS_NC00126$", new[] { "D3CO", "D375TDSI", "D375TYMD", "SYS_NC00126$" })
    };
}
