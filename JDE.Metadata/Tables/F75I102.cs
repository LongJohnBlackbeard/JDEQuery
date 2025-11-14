using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I102 - .
/// </summary>
public class F75I102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBCO.
        /// </summary>
        public const string QBCO = "QBCO";

        /// <summary>
        /// QBKCO.
        /// </summary>
        public const string QBKCO = "QBKCO";

        /// <summary>
        /// QBDCT.
        /// </summary>
        public const string QBDCT = "QBDCT";

        /// <summary>
        /// QBDOC.
        /// </summary>
        public const string QBDOC = "QBDOC";

        /// <summary>
        /// QBSFX.
        /// </summary>
        public const string QBSFX = "QBSFX";

        /// <summary>
        /// QBI75TXRG.
        /// </summary>
        public const string QBI75TXRG = "QBI75TXRG";

        /// <summary>
        /// QBI75TTYP.
        /// </summary>
        public const string QBI75TTYP = "QBI75TTYP";

        /// <summary>
        /// QBI75TDSR.
        /// </summary>
        public const string QBI75TDSR = "QBI75TDSR";

        /// <summary>
        /// QBI75TAXA.
        /// </summary>
        public const string QBI75TAXA = "QBI75TAXA";

        /// <summary>
        /// QBUPMJ.
        /// </summary>
        public const string QBUPMJ = "QBUPMJ";

        /// <summary>
        /// QBUPMT.
        /// </summary>
        public const string QBUPMT = "QBUPMT";

        /// <summary>
        /// QBPID.
        /// </summary>
        public const string QBPID = "QBPID";

        /// <summary>
        /// QBJOBN.
        /// </summary>
        public const string QBJOBN = "QBJOBN";

        /// <summary>
        /// QBUSER.
        /// </summary>
        public const string QBUSER = "QBUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75I102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBCO", "QBCO", JdeDataType.String, 10, true, true),
        new JdeField("QBKCO", "QBKCO", JdeDataType.String, 10, true, true),
        new JdeField("QBDCT", "QBDCT", JdeDataType.String, 4, true, true),
        new JdeField("QBDOC", "QBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("QBSFX", "QBSFX", JdeDataType.String, 6, true, true),
        new JdeField("QBI75TXRG", "QBI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("QBI75TTYP", "QBI75TTYP", JdeDataType.String, 10, true, true),
        new JdeField("QBI75TDSR", "QBI75TDSR", JdeDataType.Numeric),
        new JdeField("QBI75TAXA", "QBI75TAXA", JdeDataType.Numeric),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBUPMT", "QBUPMT", JdeDataType.Numeric),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I102_0", "Primary Key on QBCO, QBKCO, QBDCT, QBDOC, QBSFX, QBI75TXRG, QBI75TTYP", new[] { "QBCO", "QBKCO", "QBDCT", "QBDOC", "QBSFX", "QBI75TXRG", "QBI75TTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
