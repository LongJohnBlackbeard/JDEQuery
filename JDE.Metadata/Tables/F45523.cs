using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45523 - .
/// </summary>
public class F45523 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCDOCO.
        /// </summary>
        public const string PCDOCO = "PCDOCO";

        /// <summary>
        /// PCDCTO.
        /// </summary>
        public const string PCDCTO = "PCDCTO";

        /// <summary>
        /// PCPLGRP.
        /// </summary>
        public const string PCPLGRP = "PCPLGRP";

        /// <summary>
        /// PCPLCNBR.
        /// </summary>
        public const string PCPLCNBR = "PCPLCNBR";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45523";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCDOCO", "PCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDCTO", "PCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PCPLGRP", "PCPLGRP", JdeDataType.String, 6, true, true),
        new JdeField("PCPLCNBR", "PCPLCNBR", JdeDataType.Numeric),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45523_0", "Primary Key on PCDOCO, PCDCTO, PCPLGRP", new[] { "PCDOCO", "PCDCTO", "PCPLGRP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F45523_2", "Index on PCDOCO, PCDCTO", new[] { "PCDOCO", "PCDCTO" }),
        new JdeIndex("F45523_3", "Index on PCDOCO, PCDCTO, PCPLCNBR", new[] { "PCDOCO", "PCDCTO", "PCPLCNBR" })
    };
}
