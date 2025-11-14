using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07100 - .
/// </summary>
public class F07100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F7CO.
        /// </summary>
        public const string F7CO = "F7CO";

        /// <summary>
        /// F7SSN.
        /// </summary>
        public const string F7SSN = "F7SSN";

        /// <summary>
        /// F7AN8.
        /// </summary>
        public const string F7AN8 = "F7AN8";

        /// <summary>
        /// F7JBCD.
        /// </summary>
        public const string F7JBCD = "F7JBCD";

        /// <summary>
        /// F7JBST.
        /// </summary>
        public const string F7JBST = "F7JBST";

        /// <summary>
        /// F7MCU.
        /// </summary>
        public const string F7MCU = "F7MCU";

        /// <summary>
        /// F7IND$.
        /// </summary>
        public const string F7IND_ = "F7IND$";

        /// <summary>
        /// F7RGN$.
        /// </summary>
        public const string F7RGN_ = "F7RGN$";

        /// <summary>
        /// F7UN.
        /// </summary>
        public const string F7UN = "F7UN";

        /// <summary>
        /// F7WKS.
        /// </summary>
        public const string F7WKS = "F7WKS";

        /// <summary>
        /// F7HRWR.
        /// </summary>
        public const string F7HRWR = "F7HRWR";

        /// <summary>
        /// F7HRWT.
        /// </summary>
        public const string F7HRWT = "F7HRWT";

        /// <summary>
        /// F7HRWO.
        /// </summary>
        public const string F7HRWO = "F7HRWO";

        /// <summary>
        /// F7GPA.
        /// </summary>
        public const string F7GPA = "F7GPA";

        /// <summary>
        /// F7VCGP.
        /// </summary>
        public const string F7VCGP = "F7VCGP";

        /// <summary>
        /// F7UDC$.
        /// </summary>
        public const string F7UDC_ = "F7UDC$";

        /// <summary>
        /// F7CPPE.
        /// </summary>
        public const string F7CPPE = "F7CPPE";
    }

    /// <inheritdoc />
    public override string TableName => "F07100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F7CO", "F7CO", JdeDataType.String, 10, true, true),
        new JdeField("F7SSN", "F7SSN", JdeDataType.String, 40, true, true),
        new JdeField("F7AN8", "F7AN8", JdeDataType.Numeric),
        new JdeField("F7JBCD", "F7JBCD", JdeDataType.String, 12, true, true),
        new JdeField("F7JBST", "F7JBST", JdeDataType.String, 8, true, true),
        new JdeField("F7MCU", "F7MCU", JdeDataType.String, 24),
        new JdeField("F7IND$", "F7IND$", JdeDataType.String, 20, true, true),
        new JdeField("F7RGN$", "F7RGN$", JdeDataType.String, 60, true, true),
        new JdeField("F7UN", "F7UN", JdeDataType.String, 12, true, true),
        new JdeField("F7WKS", "F7WKS", JdeDataType.Numeric),
        new JdeField("F7HRWR", "F7HRWR", JdeDataType.Numeric),
        new JdeField("F7HRWT", "F7HRWT", JdeDataType.Numeric),
        new JdeField("F7HRWO", "F7HRWO", JdeDataType.Numeric),
        new JdeField("F7GPA", "F7GPA", JdeDataType.Numeric),
        new JdeField("F7VCGP", "F7VCGP", JdeDataType.Numeric),
        new JdeField("F7UDC$", "F7UDC$", JdeDataType.Numeric),
        new JdeField("F7CPPE", "F7CPPE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07100_0", "Primary Key on F7CO, F7SSN, F7JBCD, F7JBST, F7IND$, F7RGN$, F7UN", new[] { "F7CO", "F7SSN", "F7JBCD", "F7JBST", "F7IND$", "F7RGN$", "F7UN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07100_2", "Index on F7AN8", new[] { "F7AN8" })
    };
}
