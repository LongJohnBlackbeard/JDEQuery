using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D200 - .
/// </summary>
public class F80D200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSPRDJ.
        /// </summary>
        public const string DSPRDJ = "DSPRDJ";

        /// <summary>
        /// DSMCU.
        /// </summary>
        public const string DSMCU = "DSMCU";

        /// <summary>
        /// DSAN8.
        /// </summary>
        public const string DSAN8 = "DSAN8";

        /// <summary>
        /// DSAAP.
        /// </summary>
        public const string DSAAP = "DSAAP";

        /// <summary>
        /// DSPDSO.
        /// </summary>
        public const string DSPDSO = "DSPDSO";

        /// <summary>
        /// DSADS.
        /// </summary>
        public const string DSADS = "DSADS";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSMKEY.
        /// </summary>
        public const string DSMKEY = "DSMKEY";

        /// <summary>
        /// DSUTIME.
        /// </summary>
        public const string DSUTIME = "DSUTIME";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSPRDJ", "DSPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DSMCU", "DSMCU", JdeDataType.String, 24, true, true),
        new JdeField("DSAN8", "DSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DSAAP", "DSAAP", JdeDataType.Numeric),
        new JdeField("DSPDSO", "DSPDSO", JdeDataType.Numeric),
        new JdeField("DSADS", "DSADS", JdeDataType.Numeric),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSMKEY", "DSMKEY", JdeDataType.String, 30),
        new JdeField("DSUTIME", "DSUTIME", JdeDataType.Date),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D200_0", "Primary Key on DSPRDJ, DSMCU, DSAN8", new[] { "DSPRDJ", "DSMCU", "DSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
