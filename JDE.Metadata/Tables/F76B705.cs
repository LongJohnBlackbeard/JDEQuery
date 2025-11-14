using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B705 - .
/// </summary>
public class F76B705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISKCOO.
        /// </summary>
        public const string ISKCOO = "ISKCOO";

        /// <summary>
        /// ISDOCO.
        /// </summary>
        public const string ISDOCO = "ISDOCO";

        /// <summary>
        /// ISDCTO.
        /// </summary>
        public const string ISDCTO = "ISDCTO";

        /// <summary>
        /// ISSFXO.
        /// </summary>
        public const string ISSFXO = "ISSFXO";

        /// <summary>
        /// ISLNID.
        /// </summary>
        public const string ISLNID = "ISLNID";

        /// <summary>
        /// ISB76CTYC.
        /// </summary>
        public const string ISB76CTYC = "ISB76CTYC";

        /// <summary>
        /// ISB76SVTC.
        /// </summary>
        public const string ISB76SVTC = "ISB76SVTC";

        /// <summary>
        /// ISB76APIS.
        /// </summary>
        public const string ISB76APIS = "ISB76APIS";

        /// <summary>
        /// ISB76SFCP.
        /// </summary>
        public const string ISB76SFCP = "ISB76SFCP";

        /// <summary>
        /// ISB76SENC.
        /// </summary>
        public const string ISB76SENC = "ISB76SENC";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISKCOO", "ISKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ISDOCO", "ISDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDCTO", "ISDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ISSFXO", "ISSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ISLNID", "ISLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISB76CTYC", "ISB76CTYC", JdeDataType.String, 20),
        new JdeField("ISB76SVTC", "ISB76SVTC", JdeDataType.String, 20),
        new JdeField("ISB76APIS", "ISB76APIS", JdeDataType.String, 2),
        new JdeField("ISB76SFCP", "ISB76SFCP", JdeDataType.String, 60),
        new JdeField("ISB76SENC", "ISB76SENC", JdeDataType.String, 20),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B705_0", "Primary Key on ISKCOO, ISDOCO, ISDCTO, ISSFXO, ISLNID", new[] { "ISKCOO", "ISDOCO", "ISDCTO", "ISSFXO", "ISLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
