using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I022 - .
/// </summary>
public class F75I022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THKCO.
        /// </summary>
        public const string THKCO = "THKCO";

        /// <summary>
        /// THDOC.
        /// </summary>
        public const string THDOC = "THDOC";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THI75TXRG.
        /// </summary>
        public const string THI75TXRG = "THI75TXRG";

        /// <summary>
        /// THI75LDTY.
        /// </summary>
        public const string THI75LDTY = "THI75LDTY";

        /// <summary>
        /// THI75LDNR.
        /// </summary>
        public const string THI75LDNR = "THI75LDNR";

        /// <summary>
        /// THI75LDID.
        /// </summary>
        public const string THI75LDID = "THI75LDID";

        /// <summary>
        /// THI75LDRD.
        /// </summary>
        public const string THI75LDRD = "THI75LDRD";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THKCO", "THKCO", JdeDataType.String, 10, true, true),
        new JdeField("THDOC", "THDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4, true, true),
        new JdeField("THI75TXRG", "THI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("THI75LDTY", "THI75LDTY", JdeDataType.String, 4, true, true),
        new JdeField("THI75LDNR", "THI75LDNR", JdeDataType.String, 50),
        new JdeField("THI75LDID", "THI75LDID", JdeDataType.Numeric),
        new JdeField("THI75LDRD", "THI75LDRD", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I022_0", "Primary Key on THKCO, THDOC, THDCT, THI75TXRG, THI75LDTY", new[] { "THKCO", "THDOC", "THDCT", "THI75TXRG", "THI75LDTY" }, isUnique: true, isPrimaryKey: true)
    };
}
