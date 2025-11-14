using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48165 - .
/// </summary>
public class F48165 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KXDOCO.
        /// </summary>
        public const string KXDOCO = "KXDOCO";

        /// <summary>
        /// KXDCTO.
        /// </summary>
        public const string KXDCTO = "KXDCTO";

        /// <summary>
        /// KXRCK5.
        /// </summary>
        public const string KXRCK5 = "KXRCK5";

        /// <summary>
        /// KXKNLT.
        /// </summary>
        public const string KXKNLT = "KXKNLT";

        /// <summary>
        /// KXUKID.
        /// </summary>
        public const string KXUKID = "KXUKID";

        /// <summary>
        /// KXCRTU.
        /// </summary>
        public const string KXCRTU = "KXCRTU";

        /// <summary>
        /// KXCADT.
        /// </summary>
        public const string KXCADT = "KXCADT";

        /// <summary>
        /// KXUSER.
        /// </summary>
        public const string KXUSER = "KXUSER";

        /// <summary>
        /// KXUPMJ.
        /// </summary>
        public const string KXUPMJ = "KXUPMJ";

        /// <summary>
        /// KXJOBN.
        /// </summary>
        public const string KXJOBN = "KXJOBN";

        /// <summary>
        /// KXPID.
        /// </summary>
        public const string KXPID = "KXPID";

        /// <summary>
        /// KXUPMT.
        /// </summary>
        public const string KXUPMT = "KXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48165";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KXDOCO", "KXDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("KXDCTO", "KXDCTO", JdeDataType.String, 4, true, true),
        new JdeField("KXRCK5", "KXRCK5", JdeDataType.Numeric, null, true, true),
        new JdeField("KXKNLT", "KXKNLT", JdeDataType.String, 2, true, true),
        new JdeField("KXUKID", "KXUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KXCRTU", "KXCRTU", JdeDataType.String, 20),
        new JdeField("KXCADT", "KXCADT", JdeDataType.Numeric),
        new JdeField("KXUSER", "KXUSER", JdeDataType.String, 20),
        new JdeField("KXUPMJ", "KXUPMJ", JdeDataType.Numeric),
        new JdeField("KXJOBN", "KXJOBN", JdeDataType.String, 20),
        new JdeField("KXPID", "KXPID", JdeDataType.String, 20),
        new JdeField("KXUPMT", "KXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48165_0", "Primary Key on KXDOCO, KXDCTO, KXRCK5, KXKNLT, KXUKID", new[] { "KXDOCO", "KXDCTO", "KXRCK5", "KXKNLT", "KXUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48165_2", "Index on KXDOCO, KXDCTO, SYS_NC00013$", new[] { "KXDOCO", "KXDCTO", "SYS_NC00013$" }),
        new JdeIndex("F48165_3", "Index on KXDOCO, KXDCTO, KXRCK5, KXKNLT", new[] { "KXDOCO", "KXDCTO", "KXRCK5", "KXKNLT" })
    };
}
