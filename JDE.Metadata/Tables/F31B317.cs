using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B317 - .
/// </summary>
public class F31B317 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCWLOTN.
        /// </summary>
        public const string LCWLOTN = "LCWLOTN";

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
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

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
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCCMUSER.
        /// </summary>
        public const string LCCMUSER = "LCCMUSER";

        /// <summary>
        /// LCLTCMTOVR.
        /// </summary>
        public const string LCLTCMTOVR = "LCLTCMTOVR";
    }

    /// <inheritdoc />
    public override string TableName => "F31B317";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCWLOTN", "LCWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LCLNID", "LCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCCMCODE", "LCCMCODE", JdeDataType.String, 12),
        new JdeField("LCCMDES", "LCCMDES", JdeDataType.String, 60),
        new JdeField("LCCMMENT", "LCCMMENT", JdeDataType.String, 400),
        new JdeField("LCCMOPT", "LCCMOPT", JdeDataType.String, 2),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCCMUSER", "LCCMUSER", JdeDataType.String, 60),
        new JdeField("LCLTCMTOVR", "LCLTCMTOVR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B317_0", "Primary Key on LCMCU, LCWLOTN, LCLNID", new[] { "LCMCU", "LCWLOTN", "LCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B317_1", "Index on LCMCU, LCWLOTN, LCCMCODE", new[] { "LCMCU", "LCWLOTN", "LCCMCODE" })
    };
}
