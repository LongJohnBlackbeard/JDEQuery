using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A80 - .
/// </summary>
public class F79A80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CP79ACPID.
        /// </summary>
        public const string CP79ACPID = "CP79ACPID";

        /// <summary>
        /// CP79AGOID.
        /// </summary>
        public const string CP79AGOID = "CP79AGOID";

        /// <summary>
        /// CP79ADGHG.
        /// </summary>
        public const string CP79ADGHG = "CP79ADGHG";

        /// <summary>
        /// CP79ALG.
        /// </summary>
        public const string CP79ALG = "CP79ALG";

        /// <summary>
        /// CP79APMO.
        /// </summary>
        public const string CP79APMO = "CP79APMO";

        /// <summary>
        /// CP79AALL.
        /// </summary>
        public const string CP79AALL = "CP79AALL";

        /// <summary>
        /// CPUNCS.
        /// </summary>
        public const string CPUNCS = "CPUNCS";

        /// <summary>
        /// CPCRCD.
        /// </summary>
        public const string CPCRCD = "CPCRCD";

        /// <summary>
        /// CP79ACO2Q.
        /// </summary>
        public const string CP79ACO2Q = "CP79ACO2Q";

        /// <summary>
        /// CP79AGCUM.
        /// </summary>
        public const string CP79AGCUM = "CP79AGCUM";

        /// <summary>
        /// CP79ASGQ.
        /// </summary>
        public const string CP79ASGQ = "CP79ASGQ";

        /// <summary>
        /// CP79AGUM.
        /// </summary>
        public const string CP79AGUM = "CP79AGUM";

        /// <summary>
        /// CPBEFD.
        /// </summary>
        public const string CPBEFD = "CPBEFD";

        /// <summary>
        /// CPEEFD.
        /// </summary>
        public const string CPEEFD = "CPEEFD";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPUPMJ.
        /// </summary>
        public const string CPUPMJ = "CPUPMJ";

        /// <summary>
        /// CPUPMT.
        /// </summary>
        public const string CPUPMT = "CPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CP79ACPID", "CP79ACPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CP79AGOID", "CP79AGOID", JdeDataType.Numeric),
        new JdeField("CP79ADGHG", "CP79ADGHG", JdeDataType.Numeric),
        new JdeField("CP79ALG", "CP79ALG", JdeDataType.String, 80),
        new JdeField("CP79APMO", "CP79APMO", JdeDataType.Numeric),
        new JdeField("CP79AALL", "CP79AALL", JdeDataType.Numeric),
        new JdeField("CPUNCS", "CPUNCS", JdeDataType.Numeric),
        new JdeField("CPCRCD", "CPCRCD", JdeDataType.String, 6),
        new JdeField("CP79ACO2Q", "CP79ACO2Q", JdeDataType.Numeric),
        new JdeField("CP79AGCUM", "CP79AGCUM", JdeDataType.String, 4),
        new JdeField("CP79ASGQ", "CP79ASGQ", JdeDataType.Numeric),
        new JdeField("CP79AGUM", "CP79AGUM", JdeDataType.String, 30),
        new JdeField("CPBEFD", "CPBEFD", JdeDataType.Numeric),
        new JdeField("CPEEFD", "CPEEFD", JdeDataType.Numeric),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPUPMJ", "CPUPMJ", JdeDataType.Numeric),
        new JdeField("CPUPMT", "CPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A80_0", "Primary Key on CP79ACPID", new[] { "CP79ACPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A80_2", "Index on CP79AGOID", new[] { "CP79AGOID" }),
        new JdeIndex("F79A80_3", "Index on CP79AGOID, CP79ALG", new[] { "CP79AGOID", "CP79ALG" }),
        new JdeIndex("F79A80_4", "Unique Index on CP79AGOID, CP79ALG, CPBEFD", new[] { "CP79AGOID", "CP79ALG", "CPBEFD" }, isUnique: true)
    };
}
