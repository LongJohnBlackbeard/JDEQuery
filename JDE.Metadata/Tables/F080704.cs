using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080704 - .
/// </summary>
public class F080704 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FERCTLID.
        /// </summary>
        public const string FERCTLID = "FERCTLID";

        /// <summary>
        /// FEZIPFN.
        /// </summary>
        public const string FEZIPFN = "FEZIPFN";

        /// <summary>
        /// FEFILOC.
        /// </summary>
        public const string FEFILOC = "FEFILOC";

        /// <summary>
        /// FETMSP.
        /// </summary>
        public const string FETMSP = "FETMSP";

        /// <summary>
        /// FELBON.
        /// </summary>
        public const string FELBON = "FELBON";

        /// <summary>
        /// FEENTPID.
        /// </summary>
        public const string FEENTPID = "FEENTPID";

        /// <summary>
        /// FEUPMJ.
        /// </summary>
        public const string FEUPMJ = "FEUPMJ";

        /// <summary>
        /// FEUPMT.
        /// </summary>
        public const string FEUPMT = "FEUPMT";

        /// <summary>
        /// FEUSER.
        /// </summary>
        public const string FEUSER = "FEUSER";

        /// <summary>
        /// FEJOBN.
        /// </summary>
        public const string FEJOBN = "FEJOBN";

        /// <summary>
        /// FEPID.
        /// </summary>
        public const string FEPID = "FEPID";

        /// <summary>
        /// FEPRINST.
        /// </summary>
        public const string FEPRINST = "FEPRINST";
    }

    /// <inheritdoc />
    public override string TableName => "F080704";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FERCTLID", "FERCTLID", JdeDataType.String, 30, true, true),
        new JdeField("FEZIPFN", "FEZIPFN", JdeDataType.String, 500),
        new JdeField("FEFILOC", "FEFILOC", JdeDataType.String, 500),
        new JdeField("FETMSP", "FETMSP", JdeDataType.Date),
        new JdeField("FELBON", "FELBON", JdeDataType.String, 60, true, true),
        new JdeField("FEENTPID", "FEENTPID", JdeDataType.String, 100, true, true),
        new JdeField("FEUPMJ", "FEUPMJ", JdeDataType.Numeric),
        new JdeField("FEUPMT", "FEUPMT", JdeDataType.Numeric),
        new JdeField("FEUSER", "FEUSER", JdeDataType.String, 20),
        new JdeField("FEJOBN", "FEJOBN", JdeDataType.String, 20),
        new JdeField("FEPID", "FEPID", JdeDataType.String, 20),
        new JdeField("FEPRINST", "FEPRINST", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080704_0", "Primary Key on FERCTLID, FEPRINST, FEENTPID, FELBON", new[] { "FERCTLID", "FEPRINST", "FEENTPID", "FELBON" }, isUnique: true, isPrimaryKey: true)
    };
}
