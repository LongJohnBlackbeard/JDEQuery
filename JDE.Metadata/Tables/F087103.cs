using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087103 - .
/// </summary>
public class F087103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDTSKCD.
        /// </summary>
        public const string TDTSKCD = "TDTSKCD";

        /// <summary>
        /// TDL001.
        /// </summary>
        public const string TDL001 = "TDL001";

        /// <summary>
        /// TDL002.
        /// </summary>
        public const string TDL002 = "TDL002";

        /// <summary>
        /// TDL003.
        /// </summary>
        public const string TDL003 = "TDL003";

        /// <summary>
        /// TDL004.
        /// </summary>
        public const string TDL004 = "TDL004";

        /// <summary>
        /// TDL005.
        /// </summary>
        public const string TDL005 = "TDL005";

        /// <summary>
        /// TDL006.
        /// </summary>
        public const string TDL006 = "TDL006";

        /// <summary>
        /// TDL007.
        /// </summary>
        public const string TDL007 = "TDL007";

        /// <summary>
        /// TDL008.
        /// </summary>
        public const string TDL008 = "TDL008";

        /// <summary>
        /// TDL009.
        /// </summary>
        public const string TDL009 = "TDL009";

        /// <summary>
        /// TDL010.
        /// </summary>
        public const string TDL010 = "TDL010";

        /// <summary>
        /// TDANR.
        /// </summary>
        public const string TDANR = "TDANR";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDTYPS.
        /// </summary>
        public const string TDTYPS = "TDTYPS";

        /// <summary>
        /// TDOBNM.
        /// </summary>
        public const string TDOBNM = "TDOBNM";

        /// <summary>
        /// TDVERS.
        /// </summary>
        public const string TDVERS = "TDVERS";

        /// <summary>
        /// TDPROCNAME.
        /// </summary>
        public const string TDPROCNAME = "TDPROCNAME";

        /// <summary>
        /// TDSEM.
        /// </summary>
        public const string TDSEM = "TDSEM";

        /// <summary>
        /// TDCOS.
        /// </summary>
        public const string TDCOS = "TDCOS";

        /// <summary>
        /// TDDUR.
        /// </summary>
        public const string TDDUR = "TDDUR";

        /// <summary>
        /// TDBOD.
        /// </summary>
        public const string TDBOD = "TDBOD";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDAPRV.
        /// </summary>
        public const string TDAPRV = "TDAPRV";
    }

    /// <inheritdoc />
    public override string TableName => "F087103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDTSKCD", "TDTSKCD", JdeDataType.Numeric, null, true, true),
        new JdeField("TDL001", "TDL001", JdeDataType.String, 20, true, true),
        new JdeField("TDL002", "TDL002", JdeDataType.String, 20, true, true),
        new JdeField("TDL003", "TDL003", JdeDataType.String, 20, true, true),
        new JdeField("TDL004", "TDL004", JdeDataType.String, 20, true, true),
        new JdeField("TDL005", "TDL005", JdeDataType.String, 20, true, true),
        new JdeField("TDL006", "TDL006", JdeDataType.String, 20, true, true),
        new JdeField("TDL007", "TDL007", JdeDataType.String, 20, true, true),
        new JdeField("TDL008", "TDL008", JdeDataType.String, 20, true, true),
        new JdeField("TDL009", "TDL009", JdeDataType.String, 20, true, true),
        new JdeField("TDL010", "TDL010", JdeDataType.String, 20),
        new JdeField("TDANR", "TDANR", JdeDataType.Numeric),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric),
        new JdeField("TDTYPS", "TDTYPS", JdeDataType.String, 2),
        new JdeField("TDOBNM", "TDOBNM", JdeDataType.String, 20),
        new JdeField("TDVERS", "TDVERS", JdeDataType.String, 20),
        new JdeField("TDPROCNAME", "TDPROCNAME", JdeDataType.String, 20),
        new JdeField("TDSEM", "TDSEM", JdeDataType.String, 2),
        new JdeField("TDCOS", "TDCOS", JdeDataType.Numeric),
        new JdeField("TDDUR", "TDDUR", JdeDataType.Numeric),
        new JdeField("TDBOD", "TDBOD", JdeDataType.String, 2),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDAPRV", "TDAPRV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087103_0", "Primary Key on TDTSKCD, TDL001, TDL002, TDL003, TDL004, TDL005, TDL006, TDL007, TDL008, TDL009", new[] { "TDTSKCD", "TDL001", "TDL002", "TDL003", "TDL004", "TDL005", "TDL006", "TDL007", "TDL008", "TDL009" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087103_2", "Index on TDANR", new[] { "TDANR" }),
        new JdeIndex("F087103_3", "Index on TDAPRV", new[] { "TDAPRV" })
    };
}
