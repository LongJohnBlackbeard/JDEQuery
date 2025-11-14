using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01112 - .
/// </summary>
public class F01112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPAN8.
        /// </summary>
        public const string CPAN8 = "CPAN8";

        /// <summary>
        /// CPIDLN.
        /// </summary>
        public const string CPIDLN = "CPIDLN";

        /// <summary>
        /// CPCNLN.
        /// </summary>
        public const string CPCNLN = "CPCNLN";

        /// <summary>
        /// CPRELY.
        /// </summary>
        public const string CPRELY = "CPRELY";

        /// <summary>
        /// CPRALP.
        /// </summary>
        public const string CPRALP = "CPRALP";

        /// <summary>
        /// CPDDATE.
        /// </summary>
        public const string CPDDATE = "CPDDATE";

        /// <summary>
        /// CPDMON.
        /// </summary>
        public const string CPDMON = "CPDMON";

        /// <summary>
        /// CPDYR.
        /// </summary>
        public const string CPDYR = "CPDYR";

        /// <summary>
        /// CPCP001.
        /// </summary>
        public const string CPCP001 = "CPCP001";

        /// <summary>
        /// CPCP002.
        /// </summary>
        public const string CPCP002 = "CPCP002";

        /// <summary>
        /// CPCP003.
        /// </summary>
        public const string CPCP003 = "CPCP003";

        /// <summary>
        /// CPCP004.
        /// </summary>
        public const string CPCP004 = "CPCP004";

        /// <summary>
        /// CPCP005.
        /// </summary>
        public const string CPCP005 = "CPCP005";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";

        /// <summary>
        /// CPSYNCS.
        /// </summary>
        public const string CPSYNCS = "CPSYNCS";

        /// <summary>
        /// CPCAAD.
        /// </summary>
        public const string CPCAAD = "CPCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F01112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPAN8", "CPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CPIDLN", "CPIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCNLN", "CPCNLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CPRELY", "CPRELY", JdeDataType.String, 10),
        new JdeField("CPRALP", "CPRALP", JdeDataType.String, 80),
        new JdeField("CPDDATE", "CPDDATE", JdeDataType.Numeric),
        new JdeField("CPDMON", "CPDMON", JdeDataType.Numeric),
        new JdeField("CPDYR", "CPDYR", JdeDataType.Numeric),
        new JdeField("CPCP001", "CPCP001", JdeDataType.String, 6),
        new JdeField("CPCP002", "CPCP002", JdeDataType.String, 6),
        new JdeField("CPCP003", "CPCP003", JdeDataType.String, 6),
        new JdeField("CPCP004", "CPCP004", JdeDataType.String, 6),
        new JdeField("CPCP005", "CPCP005", JdeDataType.String, 6),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric),
        new JdeField("CPSYNCS", "CPSYNCS", JdeDataType.Numeric),
        new JdeField("CPCAAD", "CPCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01112_0", "Primary Key on CPAN8, CPIDLN, CPCNLN", new[] { "CPAN8", "CPIDLN", "CPCNLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01112_2", "Index on CPAN8, CPIDLN", new[] { "CPAN8", "CPIDLN" })
    };
}
