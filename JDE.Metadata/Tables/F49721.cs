using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49721 - .
/// </summary>
public class F49721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QSRTNM.
        /// </summary>
        public const string QSRTNM = "QSRTNM";

        /// <summary>
        /// QSSHPN.
        /// </summary>
        public const string QSSHPN = "QSSHPN";

        /// <summary>
        /// QSRSSN.
        /// </summary>
        public const string QSRSSN = "QSRSSN";

        /// <summary>
        /// QSVMCU.
        /// </summary>
        public const string QSVMCU = "QSVMCU";

        /// <summary>
        /// QSLDNM.
        /// </summary>
        public const string QSLDNM = "QSLDNM";

        /// <summary>
        /// QSDLNO.
        /// </summary>
        public const string QSDLNO = "QSDLNO";

        /// <summary>
        /// QSFRCG.
        /// </summary>
        public const string QSFRCG = "QSFRCG";

        /// <summary>
        /// QSCRCD.
        /// </summary>
        public const string QSCRCD = "QSCRCD";

        /// <summary>
        /// QSURCD.
        /// </summary>
        public const string QSURCD = "QSURCD";

        /// <summary>
        /// QSURDT.
        /// </summary>
        public const string QSURDT = "QSURDT";

        /// <summary>
        /// QSURAT.
        /// </summary>
        public const string QSURAT = "QSURAT";

        /// <summary>
        /// QSURAB.
        /// </summary>
        public const string QSURAB = "QSURAB";

        /// <summary>
        /// QSURRF.
        /// </summary>
        public const string QSURRF = "QSURRF";

        /// <summary>
        /// QSUSER.
        /// </summary>
        public const string QSUSER = "QSUSER";

        /// <summary>
        /// QSPID.
        /// </summary>
        public const string QSPID = "QSPID";

        /// <summary>
        /// QSJOBN.
        /// </summary>
        public const string QSJOBN = "QSJOBN";

        /// <summary>
        /// QSUPMJ.
        /// </summary>
        public const string QSUPMJ = "QSUPMJ";

        /// <summary>
        /// QSTDAY.
        /// </summary>
        public const string QSTDAY = "QSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QSRTNM", "QSRTNM", JdeDataType.String, 20, true, true),
        new JdeField("QSSHPN", "QSSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("QSRSSN", "QSRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("QSVMCU", "QSVMCU", JdeDataType.String, 24, true, true),
        new JdeField("QSLDNM", "QSLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("QSDLNO", "QSDLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("QSFRCG", "QSFRCG", JdeDataType.Numeric),
        new JdeField("QSCRCD", "QSCRCD", JdeDataType.String, 6),
        new JdeField("QSURCD", "QSURCD", JdeDataType.String, 4),
        new JdeField("QSURDT", "QSURDT", JdeDataType.Numeric),
        new JdeField("QSURAT", "QSURAT", JdeDataType.Numeric),
        new JdeField("QSURAB", "QSURAB", JdeDataType.Numeric),
        new JdeField("QSURRF", "QSURRF", JdeDataType.String, 30),
        new JdeField("QSUSER", "QSUSER", JdeDataType.String, 20),
        new JdeField("QSPID", "QSPID", JdeDataType.String, 20),
        new JdeField("QSJOBN", "QSJOBN", JdeDataType.String, 20),
        new JdeField("QSUPMJ", "QSUPMJ", JdeDataType.Numeric),
        new JdeField("QSTDAY", "QSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49721_0", "Primary Key on QSRTNM, QSSHPN, QSRSSN, QSVMCU, QSLDNM, QSDLNO", new[] { "QSRTNM", "QSSHPN", "QSRSSN", "QSVMCU", "QSLDNM", "QSDLNO" }, isUnique: true, isPrimaryKey: true)
    };
}
