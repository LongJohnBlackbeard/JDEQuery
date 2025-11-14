using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41171 - .
/// </summary>
public class F41171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBITM.
        /// </summary>
        public const string PBITM = "PBITM";

        /// <summary>
        /// PBMMCU.
        /// </summary>
        public const string PBMMCU = "PBMMCU";

        /// <summary>
        /// PBPRODM.
        /// </summary>
        public const string PBPRODM = "PBPRODM";

        /// <summary>
        /// PBPRODF.
        /// </summary>
        public const string PBPRODF = "PBPRODF";

        /// <summary>
        /// PBMCUZ.
        /// </summary>
        public const string PBMCUZ = "PBMCUZ";

        /// <summary>
        /// PBDCD1.
        /// </summary>
        public const string PBDCD1 = "PBDCD1";

        /// <summary>
        /// PBDCD2.
        /// </summary>
        public const string PBDCD2 = "PBDCD2";

        /// <summary>
        /// PBDCD3.
        /// </summary>
        public const string PBDCD3 = "PBDCD3";

        /// <summary>
        /// PBDCD4.
        /// </summary>
        public const string PBDCD4 = "PBDCD4";

        /// <summary>
        /// PBDCD5.
        /// </summary>
        public const string PBDCD5 = "PBDCD5";

        /// <summary>
        /// PBCRTU.
        /// </summary>
        public const string PBCRTU = "PBCRTU";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBUPMT.
        /// </summary>
        public const string PBUPMT = "PBUPMT";

        /// <summary>
        /// PBRTRND.
        /// </summary>
        public const string PBRTRND = "PBRTRND";

        /// <summary>
        /// PBRPRBL.
        /// </summary>
        public const string PBRPRBL = "PBRPRBL";

        /// <summary>
        /// PBCCOST.
        /// </summary>
        public const string PBCCOST = "PBCCOST";

        /// <summary>
        /// PBRETPOL.
        /// </summary>
        public const string PBRETPOL = "PBRETPOL";

        /// <summary>
        /// PBSRYN.
        /// </summary>
        public const string PBSRYN = "PBSRYN";

        /// <summary>
        /// PBIBYN.
        /// </summary>
        public const string PBIBYN = "PBIBYN";

        /// <summary>
        /// PBVMRS33.
        /// </summary>
        public const string PBVMRS33 = "PBVMRS33";
    }

    /// <inheritdoc />
    public override string TableName => "F41171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBITM", "PBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PBMMCU", "PBMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PBPRODM", "PBPRODM", JdeDataType.String, 16),
        new JdeField("PBPRODF", "PBPRODF", JdeDataType.String, 16),
        new JdeField("PBMCUZ", "PBMCUZ", JdeDataType.String, 24),
        new JdeField("PBDCD1", "PBDCD1", JdeDataType.String, 6),
        new JdeField("PBDCD2", "PBDCD2", JdeDataType.String, 6),
        new JdeField("PBDCD3", "PBDCD3", JdeDataType.String, 6),
        new JdeField("PBDCD4", "PBDCD4", JdeDataType.String, 6),
        new JdeField("PBDCD5", "PBDCD5", JdeDataType.String, 6),
        new JdeField("PBCRTU", "PBCRTU", JdeDataType.String, 20),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBUPMT", "PBUPMT", JdeDataType.Numeric),
        new JdeField("PBRTRND", "PBRTRND", JdeDataType.String, 2),
        new JdeField("PBRPRBL", "PBRPRBL", JdeDataType.String, 2),
        new JdeField("PBCCOST", "PBCCOST", JdeDataType.String, 6),
        new JdeField("PBRETPOL", "PBRETPOL", JdeDataType.String, 2),
        new JdeField("PBSRYN", "PBSRYN", JdeDataType.String, 2),
        new JdeField("PBIBYN", "PBIBYN", JdeDataType.String, 2),
        new JdeField("PBVMRS33", "PBVMRS33", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41171_0", "Primary Key on PBITM, PBMMCU", new[] { "PBITM", "PBMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
