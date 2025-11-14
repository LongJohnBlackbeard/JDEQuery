using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B524 - .
/// </summary>
public class F76B524 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CNJOBS.
        /// </summary>
        public const string CNJOBS = "CNJOBS";

        /// <summary>
        /// CNB76TNF.
        /// </summary>
        public const string CNB76TNF = "CNB76TNF";

        /// <summary>
        /// CNFCO.
        /// </summary>
        public const string CNFCO = "CNFCO";

        /// <summary>
        /// CNB76LSER.
        /// </summary>
        public const string CNB76LSER = "CNB76LSER";

        /// <summary>
        /// CNB76LNUM.
        /// </summary>
        public const string CNB76LNUM = "CNB76LNUM";

        /// <summary>
        /// CNUSER.
        /// </summary>
        public const string CNUSER = "CNUSER";

        /// <summary>
        /// CNUPMJ.
        /// </summary>
        public const string CNUPMJ = "CNUPMJ";

        /// <summary>
        /// CNUPMT.
        /// </summary>
        public const string CNUPMT = "CNUPMT";

        /// <summary>
        /// CNJOBN.
        /// </summary>
        public const string CNJOBN = "CNJOBN";

        /// <summary>
        /// CNPID.
        /// </summary>
        public const string CNPID = "CNPID";
    }

    /// <inheritdoc />
    public override string TableName => "F76B524";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CNJOBS", "CNJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CNB76TNF", "CNB76TNF", JdeDataType.String, 20, true, true),
        new JdeField("CNFCO", "CNFCO", JdeDataType.String, 10, true, true),
        new JdeField("CNB76LSER", "CNB76LSER", JdeDataType.String, 20, true, true),
        new JdeField("CNB76LNUM", "CNB76LNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("CNUSER", "CNUSER", JdeDataType.String, 20),
        new JdeField("CNUPMJ", "CNUPMJ", JdeDataType.Numeric),
        new JdeField("CNUPMT", "CNUPMT", JdeDataType.Numeric),
        new JdeField("CNJOBN", "CNJOBN", JdeDataType.String, 20),
        new JdeField("CNPID", "CNPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B524_0", "Primary Key on CNJOBS, CNB76TNF, CNFCO, CNB76LSER, CNB76LNUM", new[] { "CNJOBS", "CNB76TNF", "CNFCO", "CNB76LSER", "CNB76LNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
