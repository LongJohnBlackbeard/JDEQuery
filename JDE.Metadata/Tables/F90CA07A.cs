using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA07A - .
/// </summary>
public class F90CA07A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAPSAN8.
        /// </summary>
        public const string CAPSAN8 = "CAPSAN8";

        /// <summary>
        /// CAEVTID.
        /// </summary>
        public const string CAEVTID = "CAEVTID";

        /// <summary>
        /// CACNLNID.
        /// </summary>
        public const string CACNLNID = "CACNLNID";

        /// <summary>
        /// CASTSUDT.
        /// </summary>
        public const string CASTSUDT = "CASTSUDT";

        /// <summary>
        /// CAACTIND.
        /// </summary>
        public const string CAACTIND = "CAACTIND";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAVID.
        /// </summary>
        public const string CAVID = "CAVID";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAUDTTM.
        /// </summary>
        public const string CAUDTTM = "CAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA07A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAPSAN8", "CAPSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CAEVTID", "CAEVTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CACNLNID", "CACNLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CASTSUDT", "CASTSUDT", JdeDataType.Date),
        new JdeField("CAACTIND", "CAACTIND", JdeDataType.String, 2),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAVID", "CAVID", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAUDTTM", "CAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA07A_0", "Primary Key on CAPSAN8, CAEVTID, CACNLNID", new[] { "CAPSAN8", "CAEVTID", "CACNLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
