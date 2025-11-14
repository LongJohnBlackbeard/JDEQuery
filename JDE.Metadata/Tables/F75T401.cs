using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T401 - .
/// </summary>
public class F75T401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1CO.
        /// </summary>
        public const string D1CO = "D1CO";

        /// <summary>
        /// D175TDSI.
        /// </summary>
        public const string D175TDSI = "D175TDSI";

        /// <summary>
        /// D175TYMD.
        /// </summary>
        public const string D175TYMD = "D175TYMD";

        /// <summary>
        /// D1PSQ.
        /// </summary>
        public const string D1PSQ = "D1PSQ";

        /// <summary>
        /// D175TVID.
        /// </summary>
        public const string D175TVID = "D175TVID";

        /// <summary>
        /// D175TYMS.
        /// </summary>
        public const string D175TYMS = "D175TYMS";

        /// <summary>
        /// D175TYMT.
        /// </summary>
        public const string D175TYMT = "D175TYMT";

        /// <summary>
        /// D175TDBM.
        /// </summary>
        public const string D175TDBM = "D175TDBM";

        /// <summary>
        /// D175TMDU.
        /// </summary>
        public const string D175TMDU = "D175TMDU";

        /// <summary>
        /// D175TTRM.
        /// </summary>
        public const string D175TTRM = "D175TTRM";

        /// <summary>
        /// D175TUIC.
        /// </summary>
        public const string D175TUIC = "D175TUIC";

        /// <summary>
        /// D175TGDC.
        /// </summary>
        public const string D175TGDC = "D175TGDC";

        /// <summary>
        /// D175TPDC.
        /// </summary>
        public const string D175TPDC = "D175TPDC";

        /// <summary>
        /// D175TCVC.
        /// </summary>
        public const string D175TCVC = "D175TCVC";

        /// <summary>
        /// D175TRAC.
        /// </summary>
        public const string D175TRAC = "D175TRAC";

        /// <summary>
        /// D175TPFC.
        /// </summary>
        public const string D175TPFC = "D175TPFC";

        /// <summary>
        /// D175TZDC.
        /// </summary>
        public const string D175TZDC = "D175TZDC";

        /// <summary>
        /// D175TTDD.
        /// </summary>
        public const string D175TTDD = "D175TTDD";

        /// <summary>
        /// D175T001.
        /// </summary>
        public const string D175T001 = "D175T001";

        /// <summary>
        /// D175T002.
        /// </summary>
        public const string D175T002 = "D175T002";

        /// <summary>
        /// D175T005.
        /// </summary>
        public const string D175T005 = "D175T005";

        /// <summary>
        /// D175T006.
        /// </summary>
        public const string D175T006 = "D175T006";

        /// <summary>
        /// D175T009.
        /// </summary>
        public const string D175T009 = "D175T009";

        /// <summary>
        /// D175T010.
        /// </summary>
        public const string D175T010 = "D175T010";

        /// <summary>
        /// D175T013.
        /// </summary>
        public const string D175T013 = "D175T013";

        /// <summary>
        /// D175T014.
        /// </summary>
        public const string D175T014 = "D175T014";

        /// <summary>
        /// D175T017.
        /// </summary>
        public const string D175T017 = "D175T017";

        /// <summary>
        /// D175T018.
        /// </summary>
        public const string D175T018 = "D175T018";

        /// <summary>
        /// D175T021.
        /// </summary>
        public const string D175T021 = "D175T021";

        /// <summary>
        /// D175T022.
        /// </summary>
        public const string D175T022 = "D175T022";

        /// <summary>
        /// D175T003.
        /// </summary>
        public const string D175T003 = "D175T003";

        /// <summary>
        /// D175T007.
        /// </summary>
        public const string D175T007 = "D175T007";

        /// <summary>
        /// D175T011.
        /// </summary>
        public const string D175T011 = "D175T011";

        /// <summary>
        /// D175T015.
        /// </summary>
        public const string D175T015 = "D175T015";

        /// <summary>
        /// D175T019.
        /// </summary>
        public const string D175T019 = "D175T019";

        /// <summary>
        /// D175T023.
        /// </summary>
        public const string D175T023 = "D175T023";

        /// <summary>
        /// D175T025.
        /// </summary>
        public const string D175T025 = "D175T025";

        /// <summary>
        /// D175T027.
        /// </summary>
        public const string D175T027 = "D175T027";

        /// <summary>
        /// D175T028.
        /// </summary>
        public const string D175T028 = "D175T028";

        /// <summary>
        /// D175T029.
        /// </summary>
        public const string D175T029 = "D175T029";

        /// <summary>
        /// D175T030.
        /// </summary>
        public const string D175T030 = "D175T030";

        /// <summary>
        /// D175T031.
        /// </summary>
        public const string D175T031 = "D175T031";

        /// <summary>
        /// D175T032.
        /// </summary>
        public const string D175T032 = "D175T032";

        /// <summary>
        /// D175T033.
        /// </summary>
        public const string D175T033 = "D175T033";

        /// <summary>
        /// D175T034.
        /// </summary>
        public const string D175T034 = "D175T034";

        /// <summary>
        /// D175T035.
        /// </summary>
        public const string D175T035 = "D175T035";

        /// <summary>
        /// D175T036.
        /// </summary>
        public const string D175T036 = "D175T036";

        /// <summary>
        /// D175T037.
        /// </summary>
        public const string D175T037 = "D175T037";

        /// <summary>
        /// D175T038.
        /// </summary>
        public const string D175T038 = "D175T038";

        /// <summary>
        /// D175T039.
        /// </summary>
        public const string D175T039 = "D175T039";

        /// <summary>
        /// D175T078.
        /// </summary>
        public const string D175T078 = "D175T078";

        /// <summary>
        /// D175T079.
        /// </summary>
        public const string D175T079 = "D175T079";

        /// <summary>
        /// D175T080.
        /// </summary>
        public const string D175T080 = "D175T080";

        /// <summary>
        /// D175T081.
        /// </summary>
        public const string D175T081 = "D175T081";

        /// <summary>
        /// D175T040.
        /// </summary>
        public const string D175T040 = "D175T040";

        /// <summary>
        /// D175T041.
        /// </summary>
        public const string D175T041 = "D175T041";

        /// <summary>
        /// D175T042.
        /// </summary>
        public const string D175T042 = "D175T042";

        /// <summary>
        /// D175T043.
        /// </summary>
        public const string D175T043 = "D175T043";

        /// <summary>
        /// D175T044.
        /// </summary>
        public const string D175T044 = "D175T044";

        /// <summary>
        /// D175T045.
        /// </summary>
        public const string D175T045 = "D175T045";

        /// <summary>
        /// D175T046.
        /// </summary>
        public const string D175T046 = "D175T046";

        /// <summary>
        /// D175T047.
        /// </summary>
        public const string D175T047 = "D175T047";

        /// <summary>
        /// D175T048.
        /// </summary>
        public const string D175T048 = "D175T048";

        /// <summary>
        /// D175T049.
        /// </summary>
        public const string D175T049 = "D175T049";

        /// <summary>
        /// D175T067.
        /// </summary>
        public const string D175T067 = "D175T067";

        /// <summary>
        /// D175T070.
        /// </summary>
        public const string D175T070 = "D175T070";

        /// <summary>
        /// D175T073.
        /// </summary>
        public const string D175T073 = "D175T073";

        /// <summary>
        /// D175T074.
        /// </summary>
        public const string D175T074 = "D175T074";

        /// <summary>
        /// D175T101.
        /// </summary>
        public const string D175T101 = "D175T101";

        /// <summary>
        /// D175T107.
        /// </summary>
        public const string D175T107 = "D175T107";

        /// <summary>
        /// D175T108.
        /// </summary>
        public const string D175T108 = "D175T108";

        /// <summary>
        /// D175T110.
        /// </summary>
        public const string D175T110 = "D175T110";

        /// <summary>
        /// D175T111.
        /// </summary>
        public const string D175T111 = "D175T111";

        /// <summary>
        /// D175T112.
        /// </summary>
        public const string D175T112 = "D175T112";

        /// <summary>
        /// D175T113.
        /// </summary>
        public const string D175T113 = "D175T113";

        /// <summary>
        /// D175T114.
        /// </summary>
        public const string D175T114 = "D175T114";

        /// <summary>
        /// D175T115.
        /// </summary>
        public const string D175T115 = "D175T115";

        /// <summary>
        /// D175T082.
        /// </summary>
        public const string D175T082 = "D175T082";

        /// <summary>
        /// D175TGES.
        /// </summary>
        public const string D175TGES = "D175TGES";

        /// <summary>
        /// D1USER.
        /// </summary>
        public const string D1USER = "D1USER";

        /// <summary>
        /// D1PID.
        /// </summary>
        public const string D1PID = "D1PID";

        /// <summary>
        /// D1JOBN.
        /// </summary>
        public const string D1JOBN = "D1JOBN";

        /// <summary>
        /// D1UPMJ.
        /// </summary>
        public const string D1UPMJ = "D1UPMJ";

        /// <summary>
        /// D1TDAY.
        /// </summary>
        public const string D1TDAY = "D1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1CO", "D1CO", JdeDataType.String, 10, true, true),
        new JdeField("D175TDSI", "D175TDSI", JdeDataType.String, 10, true, true),
        new JdeField("D175TYMD", "D175TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("D1PSQ", "D1PSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D175TVID", "D175TVID", JdeDataType.String, 2),
        new JdeField("D175TYMS", "D175TYMS", JdeDataType.Numeric),
        new JdeField("D175TYMT", "D175TYMT", JdeDataType.Numeric),
        new JdeField("D175TDBM", "D175TDBM", JdeDataType.String, 2),
        new JdeField("D175TMDU", "D175TMDU", JdeDataType.String, 4),
        new JdeField("D175TTRM", "D175TTRM", JdeDataType.String, 6),
        new JdeField("D175TUIC", "D175TUIC", JdeDataType.Numeric),
        new JdeField("D175TGDC", "D175TGDC", JdeDataType.Numeric),
        new JdeField("D175TPDC", "D175TPDC", JdeDataType.Numeric),
        new JdeField("D175TCVC", "D175TCVC", JdeDataType.Numeric),
        new JdeField("D175TRAC", "D175TRAC", JdeDataType.Numeric),
        new JdeField("D175TPFC", "D175TPFC", JdeDataType.Numeric),
        new JdeField("D175TZDC", "D175TZDC", JdeDataType.Numeric),
        new JdeField("D175TTDD", "D175TTDD", JdeDataType.Numeric),
        new JdeField("D175T001", "D175T001", JdeDataType.Numeric),
        new JdeField("D175T002", "D175T002", JdeDataType.Numeric),
        new JdeField("D175T005", "D175T005", JdeDataType.Numeric),
        new JdeField("D175T006", "D175T006", JdeDataType.Numeric),
        new JdeField("D175T009", "D175T009", JdeDataType.Numeric),
        new JdeField("D175T010", "D175T010", JdeDataType.Numeric),
        new JdeField("D175T013", "D175T013", JdeDataType.Numeric),
        new JdeField("D175T014", "D175T014", JdeDataType.Numeric),
        new JdeField("D175T017", "D175T017", JdeDataType.Numeric),
        new JdeField("D175T018", "D175T018", JdeDataType.Numeric),
        new JdeField("D175T021", "D175T021", JdeDataType.Numeric),
        new JdeField("D175T022", "D175T022", JdeDataType.Numeric),
        new JdeField("D175T003", "D175T003", JdeDataType.Numeric),
        new JdeField("D175T007", "D175T007", JdeDataType.Numeric),
        new JdeField("D175T011", "D175T011", JdeDataType.Numeric),
        new JdeField("D175T015", "D175T015", JdeDataType.Numeric),
        new JdeField("D175T019", "D175T019", JdeDataType.Numeric),
        new JdeField("D175T023", "D175T023", JdeDataType.Numeric),
        new JdeField("D175T025", "D175T025", JdeDataType.Numeric),
        new JdeField("D175T027", "D175T027", JdeDataType.Numeric),
        new JdeField("D175T028", "D175T028", JdeDataType.Numeric),
        new JdeField("D175T029", "D175T029", JdeDataType.Numeric),
        new JdeField("D175T030", "D175T030", JdeDataType.Numeric),
        new JdeField("D175T031", "D175T031", JdeDataType.Numeric),
        new JdeField("D175T032", "D175T032", JdeDataType.Numeric),
        new JdeField("D175T033", "D175T033", JdeDataType.Numeric),
        new JdeField("D175T034", "D175T034", JdeDataType.Numeric),
        new JdeField("D175T035", "D175T035", JdeDataType.Numeric),
        new JdeField("D175T036", "D175T036", JdeDataType.Numeric),
        new JdeField("D175T037", "D175T037", JdeDataType.Numeric),
        new JdeField("D175T038", "D175T038", JdeDataType.Numeric),
        new JdeField("D175T039", "D175T039", JdeDataType.Numeric),
        new JdeField("D175T078", "D175T078", JdeDataType.Numeric),
        new JdeField("D175T079", "D175T079", JdeDataType.Numeric),
        new JdeField("D175T080", "D175T080", JdeDataType.Numeric),
        new JdeField("D175T081", "D175T081", JdeDataType.Numeric),
        new JdeField("D175T040", "D175T040", JdeDataType.Numeric),
        new JdeField("D175T041", "D175T041", JdeDataType.Numeric),
        new JdeField("D175T042", "D175T042", JdeDataType.Numeric),
        new JdeField("D175T043", "D175T043", JdeDataType.Numeric),
        new JdeField("D175T044", "D175T044", JdeDataType.Numeric),
        new JdeField("D175T045", "D175T045", JdeDataType.Numeric),
        new JdeField("D175T046", "D175T046", JdeDataType.Numeric),
        new JdeField("D175T047", "D175T047", JdeDataType.Numeric),
        new JdeField("D175T048", "D175T048", JdeDataType.Numeric),
        new JdeField("D175T049", "D175T049", JdeDataType.Numeric),
        new JdeField("D175T067", "D175T067", JdeDataType.Numeric),
        new JdeField("D175T070", "D175T070", JdeDataType.Numeric),
        new JdeField("D175T073", "D175T073", JdeDataType.Numeric),
        new JdeField("D175T074", "D175T074", JdeDataType.Numeric),
        new JdeField("D175T101", "D175T101", JdeDataType.Numeric),
        new JdeField("D175T107", "D175T107", JdeDataType.Numeric),
        new JdeField("D175T108", "D175T108", JdeDataType.Numeric),
        new JdeField("D175T110", "D175T110", JdeDataType.Numeric),
        new JdeField("D175T111", "D175T111", JdeDataType.Numeric),
        new JdeField("D175T112", "D175T112", JdeDataType.Numeric),
        new JdeField("D175T113", "D175T113", JdeDataType.Numeric),
        new JdeField("D175T114", "D175T114", JdeDataType.Numeric),
        new JdeField("D175T115", "D175T115", JdeDataType.Numeric),
        new JdeField("D175T082", "D175T082", JdeDataType.Numeric),
        new JdeField("D175TGES", "D175TGES", JdeDataType.Numeric),
        new JdeField("D1USER", "D1USER", JdeDataType.String, 20),
        new JdeField("D1PID", "D1PID", JdeDataType.String, 20),
        new JdeField("D1JOBN", "D1JOBN", JdeDataType.String, 20),
        new JdeField("D1UPMJ", "D1UPMJ", JdeDataType.Numeric),
        new JdeField("D1TDAY", "D1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T401_0", "Primary Key on D1CO, D175TDSI, D175TYMD, D1PSQ", new[] { "D1CO", "D175TDSI", "D175TYMD", "D1PSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T401_2", "Index on D1CO, D175TDSI, D175TYMD, SYS_NC00085$", new[] { "D1CO", "D175TDSI", "D175TYMD", "SYS_NC00085$" })
    };
}
