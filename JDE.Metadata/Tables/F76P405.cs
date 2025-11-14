using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P405 - .
/// </summary>
public class F76P405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGCO.
        /// </summary>
        public const string IGCO = "IGCO";

        /// <summary>
        /// IGP76CC01.
        /// </summary>
        public const string IGP76CC01 = "IGP76CC01";

        /// <summary>
        /// IGEFTJ.
        /// </summary>
        public const string IGEFTJ = "IGEFTJ";

        /// <summary>
        /// IGEFDJ.
        /// </summary>
        public const string IGEFDJ = "IGEFDJ";

        /// <summary>
        /// IGP76WHPC.
        /// </summary>
        public const string IGP76WHPC = "IGP76WHPC";

        /// <summary>
        /// IGP76WHMA.
        /// </summary>
        public const string IGP76WHMA = "IGP76WHMA";

        /// <summary>
        /// IGP76WHAT.
        /// </summary>
        public const string IGP76WHAT = "IGP76WHAT";

        /// <summary>
        /// IGH76FUA.
        /// </summary>
        public const string IGH76FUA = "IGH76FUA";

        /// <summary>
        /// IGH76FUC.
        /// </summary>
        public const string IGH76FUC = "IGH76FUC";

        /// <summary>
        /// IGH76FUD.
        /// </summary>
        public const string IGH76FUD = "IGH76FUD";

        /// <summary>
        /// IGH76FUR.
        /// </summary>
        public const string IGH76FUR = "IGH76FUR";

        /// <summary>
        /// IGH76FUF.
        /// </summary>
        public const string IGH76FUF = "IGH76FUF";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGJOBN.
        /// </summary>
        public const string IGJOBN = "IGJOBN";

        /// <summary>
        /// IGUPMJ.
        /// </summary>
        public const string IGUPMJ = "IGUPMJ";

        /// <summary>
        /// IGUPMT.
        /// </summary>
        public const string IGUPMT = "IGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGCO", "IGCO", JdeDataType.String, 10, true, true),
        new JdeField("IGP76CC01", "IGP76CC01", JdeDataType.String, 6, true, true),
        new JdeField("IGEFTJ", "IGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IGEFDJ", "IGEFDJ", JdeDataType.Numeric),
        new JdeField("IGP76WHPC", "IGP76WHPC", JdeDataType.Numeric),
        new JdeField("IGP76WHMA", "IGP76WHMA", JdeDataType.Numeric),
        new JdeField("IGP76WHAT", "IGP76WHAT", JdeDataType.String, 2),
        new JdeField("IGH76FUA", "IGH76FUA", JdeDataType.Numeric),
        new JdeField("IGH76FUC", "IGH76FUC", JdeDataType.String, 20),
        new JdeField("IGH76FUD", "IGH76FUD", JdeDataType.Numeric),
        new JdeField("IGH76FUR", "IGH76FUR", JdeDataType.String, 30),
        new JdeField("IGH76FUF", "IGH76FUF", JdeDataType.String, 2),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGJOBN", "IGJOBN", JdeDataType.String, 20),
        new JdeField("IGUPMJ", "IGUPMJ", JdeDataType.Numeric),
        new JdeField("IGUPMT", "IGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P405_0", "Primary Key on IGCO, IGP76CC01, IGEFTJ", new[] { "IGCO", "IGP76CC01", "IGEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
