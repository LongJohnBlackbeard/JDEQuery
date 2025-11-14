using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F063106 - .
/// </summary>
public class F063106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y7AN8.
        /// </summary>
        public const string Y7AN8 = "Y7AN8";

        /// <summary>
        /// Y7DISO.
        /// </summary>
        public const string Y7DISO = "Y7DISO";

        /// <summary>
        /// Y7PDBA.
        /// </summary>
        public const string Y7PDBA = "Y7PDBA";

        /// <summary>
        /// Y7HMCO.
        /// </summary>
        public const string Y7HMCO = "Y7HMCO";

        /// <summary>
        /// Y7HMCU.
        /// </summary>
        public const string Y7HMCU = "Y7HMCU";

        /// <summary>
        /// Y7MAIL.
        /// </summary>
        public const string Y7MAIL = "Y7MAIL";

        /// <summary>
        /// Y7PPED.
        /// </summary>
        public const string Y7PPED = "Y7PPED";

        /// <summary>
        /// Y7UN.
        /// </summary>
        public const string Y7UN = "Y7UN";

        /// <summary>
        /// Y7JBCD.
        /// </summary>
        public const string Y7JBCD = "Y7JBCD";

        /// <summary>
        /// Y7JBST.
        /// </summary>
        public const string Y7JBST = "Y7JBST";

        /// <summary>
        /// Y7WST.
        /// </summary>
        public const string Y7WST = "Y7WST";

        /// <summary>
        /// Y7WCNT.
        /// </summary>
        public const string Y7WCNT = "Y7WCNT";

        /// <summary>
        /// Y7WCTY.
        /// </summary>
        public const string Y7WCTY = "Y7WCTY";

        /// <summary>
        /// Y7P001.
        /// </summary>
        public const string Y7P001 = "Y7P001";

        /// <summary>
        /// Y7P002.
        /// </summary>
        public const string Y7P002 = "Y7P002";

        /// <summary>
        /// Y7P003.
        /// </summary>
        public const string Y7P003 = "Y7P003";

        /// <summary>
        /// Y7P004.
        /// </summary>
        public const string Y7P004 = "Y7P004";

        /// <summary>
        /// Y7ANN8.
        /// </summary>
        public const string Y7ANN8 = "Y7ANN8";

        /// <summary>
        /// Y7GPAY.
        /// </summary>
        public const string Y7GPAY = "Y7GPAY";

        /// <summary>
        /// Y7RTAM.
        /// </summary>
        public const string Y7RTAM = "Y7RTAM";

        /// <summary>
        /// Y7DEDM.
        /// </summary>
        public const string Y7DEDM = "Y7DEDM";

        /// <summary>
        /// Y7AMTD.
        /// </summary>
        public const string Y7AMTD = "Y7AMTD";

        /// <summary>
        /// Y7AQTD.
        /// </summary>
        public const string Y7AQTD = "Y7AQTD";

        /// <summary>
        /// Y7AYTD.
        /// </summary>
        public const string Y7AYTD = "Y7AYTD";

        /// <summary>
        /// Y7SSN.
        /// </summary>
        public const string Y7SSN = "Y7SSN";

        /// <summary>
        /// Y7OEMP.
        /// </summary>
        public const string Y7OEMP = "Y7OEMP";

        /// <summary>
        /// Y7PALF.
        /// </summary>
        public const string Y7PALF = "Y7PALF";

        /// <summary>
        /// Y7USER.
        /// </summary>
        public const string Y7USER = "Y7USER";

        /// <summary>
        /// Y7PID.
        /// </summary>
        public const string Y7PID = "Y7PID";
    }

    /// <inheritdoc />
    public override string TableName => "F063106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y7AN8", "Y7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y7DISO", "Y7DISO", JdeDataType.String, 2, true, true),
        new JdeField("Y7PDBA", "Y7PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y7HMCO", "Y7HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y7HMCU", "Y7HMCU", JdeDataType.String, 24),
        new JdeField("Y7MAIL", "Y7MAIL", JdeDataType.String, 20),
        new JdeField("Y7PPED", "Y7PPED", JdeDataType.Numeric),
        new JdeField("Y7UN", "Y7UN", JdeDataType.String, 12),
        new JdeField("Y7JBCD", "Y7JBCD", JdeDataType.String, 12),
        new JdeField("Y7JBST", "Y7JBST", JdeDataType.String, 8),
        new JdeField("Y7WST", "Y7WST", JdeDataType.Numeric),
        new JdeField("Y7WCNT", "Y7WCNT", JdeDataType.Numeric),
        new JdeField("Y7WCTY", "Y7WCTY", JdeDataType.Numeric),
        new JdeField("Y7P001", "Y7P001", JdeDataType.String, 6),
        new JdeField("Y7P002", "Y7P002", JdeDataType.String, 6),
        new JdeField("Y7P003", "Y7P003", JdeDataType.String, 6),
        new JdeField("Y7P004", "Y7P004", JdeDataType.String, 6),
        new JdeField("Y7ANN8", "Y7ANN8", JdeDataType.Numeric),
        new JdeField("Y7GPAY", "Y7GPAY", JdeDataType.Numeric),
        new JdeField("Y7RTAM", "Y7RTAM", JdeDataType.Numeric),
        new JdeField("Y7DEDM", "Y7DEDM", JdeDataType.String, 2),
        new JdeField("Y7AMTD", "Y7AMTD", JdeDataType.Numeric),
        new JdeField("Y7AQTD", "Y7AQTD", JdeDataType.Numeric),
        new JdeField("Y7AYTD", "Y7AYTD", JdeDataType.Numeric),
        new JdeField("Y7SSN", "Y7SSN", JdeDataType.String, 40),
        new JdeField("Y7OEMP", "Y7OEMP", JdeDataType.String, 16),
        new JdeField("Y7PALF", "Y7PALF", JdeDataType.String, 24),
        new JdeField("Y7USER", "Y7USER", JdeDataType.String, 20),
        new JdeField("Y7PID", "Y7PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F063106_0", "Primary Key on Y7AN8, Y7DISO, Y7PDBA, Y7HMCO", new[] { "Y7AN8", "Y7DISO", "Y7PDBA", "Y7HMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F063106_3", "Index on Y7USER, Y7PID", new[] { "Y7USER", "Y7PID" })
    };
}
