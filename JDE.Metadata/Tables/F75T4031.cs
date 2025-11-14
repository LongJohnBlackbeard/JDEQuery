using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T4031 - .
/// </summary>
public class F75T4031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1CO.
        /// </summary>
        public const string A1CO = "A1CO";

        /// <summary>
        /// A175TDSI.
        /// </summary>
        public const string A175TDSI = "A175TDSI";

        /// <summary>
        /// A175TYMD.
        /// </summary>
        public const string A175TYMD = "A175TYMD";

        /// <summary>
        /// A1PSQ.
        /// </summary>
        public const string A1PSQ = "A1PSQ";

        /// <summary>
        /// A175T0292.
        /// </summary>
        public const string A175T0292 = "A175T0292";

        /// <summary>
        /// A175T0293.
        /// </summary>
        public const string A175T0293 = "A175T0293";

        /// <summary>
        /// A175T0294.
        /// </summary>
        public const string A175T0294 = "A175T0294";

        /// <summary>
        /// A175T0295.
        /// </summary>
        public const string A175T0295 = "A175T0295";

        /// <summary>
        /// A175T0296.
        /// </summary>
        public const string A175T0296 = "A175T0296";

        /// <summary>
        /// A175T0312.
        /// </summary>
        public const string A175T0312 = "A175T0312";

        /// <summary>
        /// A175T0313.
        /// </summary>
        public const string A175T0313 = "A175T0313";

        /// <summary>
        /// A175T0314.
        /// </summary>
        public const string A175T0314 = "A175T0314";

        /// <summary>
        /// A175T0315.
        /// </summary>
        public const string A175T0315 = "A175T0315";

        /// <summary>
        /// A175T0316.
        /// </summary>
        public const string A175T0316 = "A175T0316";

        /// <summary>
        /// A175T0332.
        /// </summary>
        public const string A175T0332 = "A175T0332";

        /// <summary>
        /// A175T0333.
        /// </summary>
        public const string A175T0333 = "A175T0333";

        /// <summary>
        /// A175T0334.
        /// </summary>
        public const string A175T0334 = "A175T0334";

        /// <summary>
        /// A175T0335.
        /// </summary>
        public const string A175T0335 = "A175T0335";

        /// <summary>
        /// A175T0336.
        /// </summary>
        public const string A175T0336 = "A175T0336";

        /// <summary>
        /// A175T0352.
        /// </summary>
        public const string A175T0352 = "A175T0352";

        /// <summary>
        /// A175T0353.
        /// </summary>
        public const string A175T0353 = "A175T0353";

        /// <summary>
        /// A175T0354.
        /// </summary>
        public const string A175T0354 = "A175T0354";

        /// <summary>
        /// A175T0355.
        /// </summary>
        public const string A175T0355 = "A175T0355";

        /// <summary>
        /// A175T0356.
        /// </summary>
        public const string A175T0356 = "A175T0356";

        /// <summary>
        /// A175T0372.
        /// </summary>
        public const string A175T0372 = "A175T0372";

        /// <summary>
        /// A175T0373.
        /// </summary>
        public const string A175T0373 = "A175T0373";

        /// <summary>
        /// A175T0374.
        /// </summary>
        public const string A175T0374 = "A175T0374";

        /// <summary>
        /// A175T0375.
        /// </summary>
        public const string A175T0375 = "A175T0375";

        /// <summary>
        /// A175T0376.
        /// </summary>
        public const string A175T0376 = "A175T0376";

        /// <summary>
        /// A175T0392.
        /// </summary>
        public const string A175T0392 = "A175T0392";

        /// <summary>
        /// A175T0393.
        /// </summary>
        public const string A175T0393 = "A175T0393";

        /// <summary>
        /// A175T0394.
        /// </summary>
        public const string A175T0394 = "A175T0394";

        /// <summary>
        /// A175T0395.
        /// </summary>
        public const string A175T0395 = "A175T0395";

        /// <summary>
        /// A175T0396.
        /// </summary>
        public const string A175T0396 = "A175T0396";

        /// <summary>
        /// A175T0792.
        /// </summary>
        public const string A175T0792 = "A175T0792";

        /// <summary>
        /// A175T0793.
        /// </summary>
        public const string A175T0793 = "A175T0793";

        /// <summary>
        /// A175T0794.
        /// </summary>
        public const string A175T0794 = "A175T0794";

        /// <summary>
        /// A175T0795.
        /// </summary>
        public const string A175T0795 = "A175T0795";

        /// <summary>
        /// A175T0796.
        /// </summary>
        public const string A175T0796 = "A175T0796";

        /// <summary>
        /// A175T0812.
        /// </summary>
        public const string A175T0812 = "A175T0812";

        /// <summary>
        /// A175T0813.
        /// </summary>
        public const string A175T0813 = "A175T0813";

        /// <summary>
        /// A175T0814.
        /// </summary>
        public const string A175T0814 = "A175T0814";

        /// <summary>
        /// A175T0815.
        /// </summary>
        public const string A175T0815 = "A175T0815";

        /// <summary>
        /// A175T0816.
        /// </summary>
        public const string A175T0816 = "A175T0816";

        /// <summary>
        /// A175T0412.
        /// </summary>
        public const string A175T0412 = "A175T0412";

        /// <summary>
        /// A175T0413.
        /// </summary>
        public const string A175T0413 = "A175T0413";

        /// <summary>
        /// A175T0414.
        /// </summary>
        public const string A175T0414 = "A175T0414";

        /// <summary>
        /// A175T0415.
        /// </summary>
        public const string A175T0415 = "A175T0415";

        /// <summary>
        /// A175T0416.
        /// </summary>
        public const string A175T0416 = "A175T0416";

        /// <summary>
        /// A175T0432.
        /// </summary>
        public const string A175T0432 = "A175T0432";

        /// <summary>
        /// A175T0433.
        /// </summary>
        public const string A175T0433 = "A175T0433";

        /// <summary>
        /// A175T0434.
        /// </summary>
        public const string A175T0434 = "A175T0434";

        /// <summary>
        /// A175T0435.
        /// </summary>
        public const string A175T0435 = "A175T0435";

        /// <summary>
        /// A175T0436.
        /// </summary>
        public const string A175T0436 = "A175T0436";

        /// <summary>
        /// A175T0452.
        /// </summary>
        public const string A175T0452 = "A175T0452";

        /// <summary>
        /// A175T0453.
        /// </summary>
        public const string A175T0453 = "A175T0453";

        /// <summary>
        /// A175T0454.
        /// </summary>
        public const string A175T0454 = "A175T0454";

        /// <summary>
        /// A175T0455.
        /// </summary>
        public const string A175T0455 = "A175T0455";

        /// <summary>
        /// A175T0456.
        /// </summary>
        public const string A175T0456 = "A175T0456";

        /// <summary>
        /// A175T0472.
        /// </summary>
        public const string A175T0472 = "A175T0472";

        /// <summary>
        /// A175T0473.
        /// </summary>
        public const string A175T0473 = "A175T0473";

        /// <summary>
        /// A175T0474.
        /// </summary>
        public const string A175T0474 = "A175T0474";

        /// <summary>
        /// A175T0475.
        /// </summary>
        public const string A175T0475 = "A175T0475";

        /// <summary>
        /// A175T0476.
        /// </summary>
        public const string A175T0476 = "A175T0476";

        /// <summary>
        /// A175T029.
        /// </summary>
        public const string A175T029 = "A175T029";

        /// <summary>
        /// A175T031.
        /// </summary>
        public const string A175T031 = "A175T031";

        /// <summary>
        /// A175T033.
        /// </summary>
        public const string A175T033 = "A175T033";

        /// <summary>
        /// A175T035.
        /// </summary>
        public const string A175T035 = "A175T035";

        /// <summary>
        /// A175T037.
        /// </summary>
        public const string A175T037 = "A175T037";

        /// <summary>
        /// A175T039.
        /// </summary>
        public const string A175T039 = "A175T039";

        /// <summary>
        /// A175T079.
        /// </summary>
        public const string A175T079 = "A175T079";

        /// <summary>
        /// A175T081.
        /// </summary>
        public const string A175T081 = "A175T081";

        /// <summary>
        /// A175T041.
        /// </summary>
        public const string A175T041 = "A175T041";

        /// <summary>
        /// A175T043.
        /// </summary>
        public const string A175T043 = "A175T043";

        /// <summary>
        /// A175T045.
        /// </summary>
        public const string A175T045 = "A175T045";

        /// <summary>
        /// A175T047.
        /// </summary>
        public const string A175T047 = "A175T047";

        /// <summary>
        /// A175T051.
        /// </summary>
        public const string A175T051 = "A175T051";

        /// <summary>
        /// A1USER.
        /// </summary>
        public const string A1USER = "A1USER";

        /// <summary>
        /// A1PID.
        /// </summary>
        public const string A1PID = "A1PID";

        /// <summary>
        /// A1JOBN.
        /// </summary>
        public const string A1JOBN = "A1JOBN";

        /// <summary>
        /// A1UPMJ.
        /// </summary>
        public const string A1UPMJ = "A1UPMJ";

        /// <summary>
        /// A1TDAY.
        /// </summary>
        public const string A1TDAY = "A1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T4031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1CO", "A1CO", JdeDataType.String, 10, true, true),
        new JdeField("A175TDSI", "A175TDSI", JdeDataType.String, 10, true, true),
        new JdeField("A175TYMD", "A175TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("A1PSQ", "A1PSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("A175T0292", "A175T0292", JdeDataType.Numeric),
        new JdeField("A175T0293", "A175T0293", JdeDataType.Numeric),
        new JdeField("A175T0294", "A175T0294", JdeDataType.Numeric),
        new JdeField("A175T0295", "A175T0295", JdeDataType.Numeric),
        new JdeField("A175T0296", "A175T0296", JdeDataType.Numeric),
        new JdeField("A175T0312", "A175T0312", JdeDataType.Numeric),
        new JdeField("A175T0313", "A175T0313", JdeDataType.Numeric),
        new JdeField("A175T0314", "A175T0314", JdeDataType.Numeric),
        new JdeField("A175T0315", "A175T0315", JdeDataType.Numeric),
        new JdeField("A175T0316", "A175T0316", JdeDataType.Numeric),
        new JdeField("A175T0332", "A175T0332", JdeDataType.Numeric),
        new JdeField("A175T0333", "A175T0333", JdeDataType.Numeric),
        new JdeField("A175T0334", "A175T0334", JdeDataType.Numeric),
        new JdeField("A175T0335", "A175T0335", JdeDataType.Numeric),
        new JdeField("A175T0336", "A175T0336", JdeDataType.Numeric),
        new JdeField("A175T0352", "A175T0352", JdeDataType.Numeric),
        new JdeField("A175T0353", "A175T0353", JdeDataType.Numeric),
        new JdeField("A175T0354", "A175T0354", JdeDataType.Numeric),
        new JdeField("A175T0355", "A175T0355", JdeDataType.Numeric),
        new JdeField("A175T0356", "A175T0356", JdeDataType.Numeric),
        new JdeField("A175T0372", "A175T0372", JdeDataType.Numeric),
        new JdeField("A175T0373", "A175T0373", JdeDataType.Numeric),
        new JdeField("A175T0374", "A175T0374", JdeDataType.Numeric),
        new JdeField("A175T0375", "A175T0375", JdeDataType.Numeric),
        new JdeField("A175T0376", "A175T0376", JdeDataType.Numeric),
        new JdeField("A175T0392", "A175T0392", JdeDataType.Numeric),
        new JdeField("A175T0393", "A175T0393", JdeDataType.Numeric),
        new JdeField("A175T0394", "A175T0394", JdeDataType.Numeric),
        new JdeField("A175T0395", "A175T0395", JdeDataType.Numeric),
        new JdeField("A175T0396", "A175T0396", JdeDataType.Numeric),
        new JdeField("A175T0792", "A175T0792", JdeDataType.Numeric),
        new JdeField("A175T0793", "A175T0793", JdeDataType.Numeric),
        new JdeField("A175T0794", "A175T0794", JdeDataType.Numeric),
        new JdeField("A175T0795", "A175T0795", JdeDataType.Numeric),
        new JdeField("A175T0796", "A175T0796", JdeDataType.Numeric),
        new JdeField("A175T0812", "A175T0812", JdeDataType.Numeric),
        new JdeField("A175T0813", "A175T0813", JdeDataType.Numeric),
        new JdeField("A175T0814", "A175T0814", JdeDataType.Numeric),
        new JdeField("A175T0815", "A175T0815", JdeDataType.Numeric),
        new JdeField("A175T0816", "A175T0816", JdeDataType.Numeric),
        new JdeField("A175T0412", "A175T0412", JdeDataType.Numeric),
        new JdeField("A175T0413", "A175T0413", JdeDataType.Numeric),
        new JdeField("A175T0414", "A175T0414", JdeDataType.Numeric),
        new JdeField("A175T0415", "A175T0415", JdeDataType.Numeric),
        new JdeField("A175T0416", "A175T0416", JdeDataType.Numeric),
        new JdeField("A175T0432", "A175T0432", JdeDataType.Numeric),
        new JdeField("A175T0433", "A175T0433", JdeDataType.Numeric),
        new JdeField("A175T0434", "A175T0434", JdeDataType.Numeric),
        new JdeField("A175T0435", "A175T0435", JdeDataType.Numeric),
        new JdeField("A175T0436", "A175T0436", JdeDataType.Numeric),
        new JdeField("A175T0452", "A175T0452", JdeDataType.Numeric),
        new JdeField("A175T0453", "A175T0453", JdeDataType.Numeric),
        new JdeField("A175T0454", "A175T0454", JdeDataType.Numeric),
        new JdeField("A175T0455", "A175T0455", JdeDataType.Numeric),
        new JdeField("A175T0456", "A175T0456", JdeDataType.Numeric),
        new JdeField("A175T0472", "A175T0472", JdeDataType.Numeric),
        new JdeField("A175T0473", "A175T0473", JdeDataType.Numeric),
        new JdeField("A175T0474", "A175T0474", JdeDataType.Numeric),
        new JdeField("A175T0475", "A175T0475", JdeDataType.Numeric),
        new JdeField("A175T0476", "A175T0476", JdeDataType.Numeric),
        new JdeField("A175T029", "A175T029", JdeDataType.Numeric),
        new JdeField("A175T031", "A175T031", JdeDataType.Numeric),
        new JdeField("A175T033", "A175T033", JdeDataType.Numeric),
        new JdeField("A175T035", "A175T035", JdeDataType.Numeric),
        new JdeField("A175T037", "A175T037", JdeDataType.Numeric),
        new JdeField("A175T039", "A175T039", JdeDataType.Numeric),
        new JdeField("A175T079", "A175T079", JdeDataType.Numeric),
        new JdeField("A175T081", "A175T081", JdeDataType.Numeric),
        new JdeField("A175T041", "A175T041", JdeDataType.Numeric),
        new JdeField("A175T043", "A175T043", JdeDataType.Numeric),
        new JdeField("A175T045", "A175T045", JdeDataType.Numeric),
        new JdeField("A175T047", "A175T047", JdeDataType.Numeric),
        new JdeField("A175T051", "A175T051", JdeDataType.Numeric),
        new JdeField("A1USER", "A1USER", JdeDataType.String, 20),
        new JdeField("A1PID", "A1PID", JdeDataType.String, 20),
        new JdeField("A1JOBN", "A1JOBN", JdeDataType.String, 20),
        new JdeField("A1UPMJ", "A1UPMJ", JdeDataType.Numeric),
        new JdeField("A1TDAY", "A1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T4031_0", "Primary Key on A1CO, A175TDSI, A175TYMD, A1PSQ", new[] { "A1CO", "A175TDSI", "A175TYMD", "A1PSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
