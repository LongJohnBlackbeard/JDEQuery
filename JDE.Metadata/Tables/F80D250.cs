using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D250 - .
/// </summary>
public class F80D250 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSPRDJ.
        /// </summary>
        public const string PSPRDJ = "PSPRDJ";

        /// <summary>
        /// PSMCU.
        /// </summary>
        public const string PSMCU = "PSMCU";

        /// <summary>
        /// PSAN8.
        /// </summary>
        public const string PSAN8 = "PSAN8";

        /// <summary>
        /// PSRECVE.
        /// </summary>
        public const string PSRECVE = "PSRECVE";

        /// <summary>
        /// PSRECVOT.
        /// </summary>
        public const string PSRECVOT = "PSRECVOT";

        /// <summary>
        /// PSRECVL.
        /// </summary>
        public const string PSRECVL = "PSRECVL";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSMKEY.
        /// </summary>
        public const string PSMKEY = "PSMKEY";

        /// <summary>
        /// PSUTIME.
        /// </summary>
        public const string PSUTIME = "PSUTIME";

        /// <summary>
        /// PSURCD.
        /// </summary>
        public const string PSURCD = "PSURCD";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D250";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSPRDJ", "PSPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PSMCU", "PSMCU", JdeDataType.String, 24, true, true),
        new JdeField("PSAN8", "PSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PSRECVE", "PSRECVE", JdeDataType.Numeric),
        new JdeField("PSRECVOT", "PSRECVOT", JdeDataType.Numeric),
        new JdeField("PSRECVL", "PSRECVL", JdeDataType.Numeric),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSMKEY", "PSMKEY", JdeDataType.String, 30),
        new JdeField("PSUTIME", "PSUTIME", JdeDataType.Date),
        new JdeField("PSURCD", "PSURCD", JdeDataType.String, 4),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D250_0", "Primary Key on PSPRDJ, PSMCU, PSAN8", new[] { "PSPRDJ", "PSMCU", "PSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
