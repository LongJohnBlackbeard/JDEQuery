using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051125 - .
/// </summary>
public class F051125 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSHMCO.
        /// </summary>
        public const string MSHMCO = "MSHMCO";

        /// <summary>
        /// MSHMCU.
        /// </summary>
        public const string MSHMCU = "MSHMCU";

        /// <summary>
        /// MSMOBSEQ.
        /// </summary>
        public const string MSMOBSEQ = "MSMOBSEQ";

        /// <summary>
        /// MSDTAI.
        /// </summary>
        public const string MSDTAI = "MSDTAI";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";

        /// <summary>
        /// MSUPMT.
        /// </summary>
        public const string MSUPMT = "MSUPMT";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F051125";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSHMCO", "MSHMCO", JdeDataType.String, 10, true, true),
        new JdeField("MSHMCU", "MSHMCU", JdeDataType.String, 24, true, true),
        new JdeField("MSMOBSEQ", "MSMOBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MSDTAI", "MSDTAI", JdeDataType.String, 20),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20),
        new JdeField("MSUPMT", "MSUPMT", JdeDataType.Numeric),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051125_0", "Primary Key on MSHMCO, MSHMCU, MSMOBSEQ", new[] { "MSHMCO", "MSHMCU", "MSMOBSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
