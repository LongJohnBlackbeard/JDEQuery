using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C9F01 - .
/// </summary>
public class F76C9F01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCC76FMT.
        /// </summary>
        public const string SCC76FMT = "SCC76FMT";

        /// <summary>
        /// SCAID.
        /// </summary>
        public const string SCAID = "SCAID";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCOBJ.
        /// </summary>
        public const string SCOBJ = "SCOBJ";

        /// <summary>
        /// SCSUB.
        /// </summary>
        public const string SCSUB = "SCSUB";

        /// <summary>
        /// SCC76CEPT.
        /// </summary>
        public const string SCC76CEPT = "SCC76CEPT";

        /// <summary>
        /// SCFMOD.
        /// </summary>
        public const string SCFMOD = "SCFMOD";

        /// <summary>
        /// SCC76TYACC.
        /// </summary>
        public const string SCC76TYACC = "SCC76TYACC";

        /// <summary>
        /// SCC76DEDU.
        /// </summary>
        public const string SCC76DEDU = "SCC76DEDU";

        /// <summary>
        /// SCC76CLAS1.
        /// </summary>
        public const string SCC76CLAS1 = "SCC76CLAS1";

        /// <summary>
        /// SCC76CLAS2.
        /// </summary>
        public const string SCC76CLAS2 = "SCC76CLAS2";

        /// <summary>
        /// SCC76CLAS3.
        /// </summary>
        public const string SCC76CLAS3 = "SCC76CLAS3";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCVERS.
        /// </summary>
        public const string SCVERS = "SCVERS";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F76C9F01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCC76FMT", "SCC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("SCAID", "SCAID", JdeDataType.String, 16, true, true),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24),
        new JdeField("SCOBJ", "SCOBJ", JdeDataType.String, 12),
        new JdeField("SCSUB", "SCSUB", JdeDataType.String, 16),
        new JdeField("SCC76CEPT", "SCC76CEPT", JdeDataType.String, 8),
        new JdeField("SCFMOD", "SCFMOD", JdeDataType.String, 2),
        new JdeField("SCC76TYACC", "SCC76TYACC", JdeDataType.String, 4),
        new JdeField("SCC76DEDU", "SCC76DEDU", JdeDataType.String, 2),
        new JdeField("SCC76CLAS1", "SCC76CLAS1", JdeDataType.String, 6),
        new JdeField("SCC76CLAS2", "SCC76CLAS2", JdeDataType.String, 6),
        new JdeField("SCC76CLAS3", "SCC76CLAS3", JdeDataType.String, 6),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCVERS", "SCVERS", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C9F01_0", "Primary Key on SCC76FMT, SCAID", new[] { "SCC76FMT", "SCAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C9F01_2", "Index on SCC76FMT, SCMCU, SCOBJ, SCSUB", new[] { "SCC76FMT", "SCMCU", "SCOBJ", "SCSUB" }),
        new JdeIndex("F76C9F01_3", "Index on SCC76FMT, SCAID, SCC76TYACC", new[] { "SCC76FMT", "SCAID", "SCC76TYACC" }),
        new JdeIndex("F76C9F01_4", "Index on SCC76FMT, SCAID, SCC76DEDU", new[] { "SCC76FMT", "SCAID", "SCC76DEDU" })
    };
}
