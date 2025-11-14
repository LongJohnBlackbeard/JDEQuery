using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34401T - .
/// </summary>
public class F34401T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNPMPN.
        /// </summary>
        public const string PNPMPN = "PNPMPN";

        /// <summary>
        /// PNPNS.
        /// </summary>
        public const string PNPNS = "PNPNS";

        /// <summary>
        /// PNKCO.
        /// </summary>
        public const string PNKCO = "PNKCO";

        /// <summary>
        /// PNMCU.
        /// </summary>
        public const string PNMCU = "PNMCU";

        /// <summary>
        /// PNDOCO.
        /// </summary>
        public const string PNDOCO = "PNDOCO";

        /// <summary>
        /// PNPMPNL.
        /// </summary>
        public const string PNPMPNL = "PNPMPNL";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNTDAY.
        /// </summary>
        public const string PNTDAY = "PNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F34401T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNPMPN", "PNPMPN", JdeDataType.String, 60),
        new JdeField("PNPNS", "PNPNS", JdeDataType.Numeric, null, true, true),
        new JdeField("PNKCO", "PNKCO", JdeDataType.String, 10, true, true),
        new JdeField("PNMCU", "PNMCU", JdeDataType.String, 24),
        new JdeField("PNDOCO", "PNDOCO", JdeDataType.Numeric),
        new JdeField("PNPMPNL", "PNPMPNL", JdeDataType.String, 128),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNTDAY", "PNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34401T_0", "Primary Key on PNKCO, PNPNS", new[] { "PNKCO", "PNPNS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34401T_2", "Index on PNPMPN", new[] { "PNPMPN" })
    };
}
