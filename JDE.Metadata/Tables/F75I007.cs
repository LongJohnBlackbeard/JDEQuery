using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I007 - .
/// </summary>
public class F75I007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCLVLA.
        /// </summary>
        public const string LCLVLA = "LCLVLA";

        /// <summary>
        /// LCI75TXTY.
        /// </summary>
        public const string LCI75TXTY = "LCI75TXTY";

        /// <summary>
        /// LCI75TXRG.
        /// </summary>
        public const string LCI75TXRG = "LCI75TXRG";

        /// <summary>
        /// LCI75RECU.
        /// </summary>
        public const string LCI75RECU = "LCI75RECU";

        /// <summary>
        /// LCI75DFFG.
        /// </summary>
        public const string LCI75DFFG = "LCI75DFFG";

        /// <summary>
        /// LCTORG.
        /// </summary>
        public const string LCTORG = "LCTORG";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCLVLA", "LCLVLA", JdeDataType.String, 6, true, true),
        new JdeField("LCI75TXTY", "LCI75TXTY", JdeDataType.String, 10),
        new JdeField("LCI75TXRG", "LCI75TXRG", JdeDataType.String, 10),
        new JdeField("LCI75RECU", "LCI75RECU", JdeDataType.String, 2),
        new JdeField("LCI75DFFG", "LCI75DFFG", JdeDataType.String, 2),
        new JdeField("LCTORG", "LCTORG", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I007_0", "Primary Key on LCLVLA", new[] { "LCLVLA" }, isUnique: true, isPrimaryKey: true)
    };
}
