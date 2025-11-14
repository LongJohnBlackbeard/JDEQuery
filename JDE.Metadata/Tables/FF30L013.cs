using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L013 - .
/// </summary>
public class FF30L013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSTERM.
        /// </summary>
        public const string DSTERM = "DSTERM";

        /// <summary>
        /// DSFSCID.
        /// </summary>
        public const string DSFSCID = "DSFSCID";

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

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSMKEY.
        /// </summary>
        public const string DSMKEY = "DSMKEY";

        /// <summary>
        /// DSUUPMJ.
        /// </summary>
        public const string DSUUPMJ = "DSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSTERM", "DSTERM", JdeDataType.String, 20, true, true),
        new JdeField("DSFSCID", "DSFSCID", JdeDataType.Numeric),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSMKEY", "DSMKEY", JdeDataType.String, 30),
        new JdeField("DSUUPMJ", "DSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L013_0", "Primary Key on DSTERM", new[] { "DSTERM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L013_2", "Index on DSFSCID", new[] { "DSFSCID" })
    };
}
