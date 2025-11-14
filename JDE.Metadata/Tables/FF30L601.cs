using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L601 - .
/// </summary>
public class FF30L601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMEMPN.
        /// </summary>
        public const string EMEMPN = "EMEMPN";

        /// <summary>
        /// EMFSCID.
        /// </summary>
        public const string EMFSCID = "EMFSCID";

        /// <summary>
        /// EMNAMED.
        /// </summary>
        public const string EMNAMED = "EMNAMED";

        /// <summary>
        /// EMRMK.
        /// </summary>
        public const string EMRMK = "EMRMK";

        /// <summary>
        /// EMURCD.
        /// </summary>
        public const string EMURCD = "EMURCD";

        /// <summary>
        /// EMURDT.
        /// </summary>
        public const string EMURDT = "EMURDT";

        /// <summary>
        /// EMURAT.
        /// </summary>
        public const string EMURAT = "EMURAT";

        /// <summary>
        /// EMURAB.
        /// </summary>
        public const string EMURAB = "EMURAB";

        /// <summary>
        /// EMURRF.
        /// </summary>
        public const string EMURRF = "EMURRF";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMMKEY.
        /// </summary>
        public const string EMMKEY = "EMMKEY";

        /// <summary>
        /// EMUUPMJ.
        /// </summary>
        public const string EMUUPMJ = "EMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMEMPN", "EMEMPN", JdeDataType.Numeric, null, true, true),
        new JdeField("EMFSCID", "EMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("EMNAMED", "EMNAMED", JdeDataType.String, 80),
        new JdeField("EMRMK", "EMRMK", JdeDataType.String, 60),
        new JdeField("EMURCD", "EMURCD", JdeDataType.String, 4),
        new JdeField("EMURDT", "EMURDT", JdeDataType.Numeric),
        new JdeField("EMURAT", "EMURAT", JdeDataType.Numeric),
        new JdeField("EMURAB", "EMURAB", JdeDataType.Numeric),
        new JdeField("EMURRF", "EMURRF", JdeDataType.String, 30),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMMKEY", "EMMKEY", JdeDataType.String, 30),
        new JdeField("EMUUPMJ", "EMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L601_0", "Primary Key on EMEMPN, EMFSCID", new[] { "EMEMPN", "EMFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L601_2", "Index on EMFSCID", new[] { "EMFSCID" })
    };
}
