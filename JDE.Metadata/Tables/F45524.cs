using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45524 - .
/// </summary>
public class F45524 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIDOCO.
        /// </summary>
        public const string PIDOCO = "PIDOCO";

        /// <summary>
        /// PIDCTO.
        /// </summary>
        public const string PIDCTO = "PIDCTO";

        /// <summary>
        /// PIITM.
        /// </summary>
        public const string PIITM = "PIITM";

        /// <summary>
        /// PILITM.
        /// </summary>
        public const string PILITM = "PILITM";

        /// <summary>
        /// PIAITM.
        /// </summary>
        public const string PIAITM = "PIAITM";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45524";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIDOCO", "PIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDCTO", "PIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PIITM", "PIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PILITM", "PILITM", JdeDataType.String, 50),
        new JdeField("PIAITM", "PIAITM", JdeDataType.String, 50),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45524_0", "Primary Key on PIDOCO, PIDCTO, PIITM", new[] { "PIDOCO", "PIDCTO", "PIITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F45524_2", "Index on PIDOCO, PIDCTO", new[] { "PIDOCO", "PIDCTO" })
    };
}
