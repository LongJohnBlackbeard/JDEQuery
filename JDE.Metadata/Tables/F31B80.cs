using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B80 - .
/// </summary>
public class F31B80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCWCFGID.
        /// </summary>
        public const string LCWCFGID = "LCWCFGID";

        /// <summary>
        /// LCLNID.
        /// </summary>
        public const string LCLNID = "LCLNID";

        /// <summary>
        /// LCCMCODE.
        /// </summary>
        public const string LCCMCODE = "LCCMCODE";

        /// <summary>
        /// LCCMDES.
        /// </summary>
        public const string LCCMDES = "LCCMDES";

        /// <summary>
        /// LCCMMENT.
        /// </summary>
        public const string LCCMMENT = "LCCMMENT";

        /// <summary>
        /// LCCMOPT.
        /// </summary>
        public const string LCCMOPT = "LCCMOPT";

        /// <summary>
        /// LCWCFTF.
        /// </summary>
        public const string LCWCFTF = "LCWCFTF";

        /// <summary>
        /// LCWLCARF.
        /// </summary>
        public const string LCWLCARF = "LCWLCARF";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCWCFGID", "LCWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCLNID", "LCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCCMCODE", "LCCMCODE", JdeDataType.String, 12),
        new JdeField("LCCMDES", "LCCMDES", JdeDataType.String, 60),
        new JdeField("LCCMMENT", "LCCMMENT", JdeDataType.String, 400),
        new JdeField("LCCMOPT", "LCCMOPT", JdeDataType.String, 2),
        new JdeField("LCWCFTF", "LCWCFTF", JdeDataType.String, 2),
        new JdeField("LCWLCARF", "LCWLCARF", JdeDataType.String, 2),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B80_0", "Primary Key on LCWCFGID, LCLNID", new[] { "LCWCFGID", "LCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B80_2", "Index on LCWCFGID, LCCMCODE", new[] { "LCWCFGID", "LCCMCODE" })
    };
}
