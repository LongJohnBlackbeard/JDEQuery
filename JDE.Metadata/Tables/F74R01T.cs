using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R01T - .
/// </summary>
public class F74R01T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTR74PCID.
        /// </summary>
        public const string PTR74PCID = "PTR74PCID";

        /// <summary>
        /// PTK74LECO.
        /// </summary>
        public const string PTK74LECO = "PTK74LECO";

        /// <summary>
        /// PTK74ISPL.
        /// </summary>
        public const string PTK74ISPL = "PTK74ISPL";

        /// <summary>
        /// PTR74PRCB.
        /// </summary>
        public const string PTR74PRCB = "PTR74PRCB";

        /// <summary>
        /// PTR74COAC.
        /// </summary>
        public const string PTR74COAC = "PTR74COAC";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R01T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTR74PCID", "PTR74PCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PTK74LECO", "PTK74LECO", JdeDataType.String, 10),
        new JdeField("PTK74ISPL", "PTK74ISPL", JdeDataType.String, 30),
        new JdeField("PTR74PRCB", "PTR74PRCB", JdeDataType.String, 2),
        new JdeField("PTR74COAC", "PTR74COAC", JdeDataType.String, 16),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R01T_0", "Primary Key on PTR74PCID", new[] { "PTR74PCID" }, isUnique: true, isPrimaryKey: true)
    };
}
