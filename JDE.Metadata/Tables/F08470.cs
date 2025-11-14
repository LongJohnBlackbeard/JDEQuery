using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08470 - .
/// </summary>
public class F08470 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPPSTNO.
        /// </summary>
        public const string JPPSTNO = "JPPSTNO";

        /// <summary>
        /// JPPSTCAT.
        /// </summary>
        public const string JPPSTCAT = "JPPSTCAT";

        /// <summary>
        /// JPREQN.
        /// </summary>
        public const string JPREQN = "JPREQN";

        /// <summary>
        /// JPPSTSTS.
        /// </summary>
        public const string JPPSTSTS = "JPPSTSTS";

        /// <summary>
        /// JPPSTDI.
        /// </summary>
        public const string JPPSTDI = "JPPSTDI";

        /// <summary>
        /// JPPSTDEI.
        /// </summary>
        public const string JPPSTDEI = "JPPSTDEI";

        /// <summary>
        /// JPPSTDE.
        /// </summary>
        public const string JPPSTDE = "JPPSTDE";

        /// <summary>
        /// JPPSTDEE.
        /// </summary>
        public const string JPPSTDEE = "JPPSTDEE";

        /// <summary>
        /// JPSALLO.
        /// </summary>
        public const string JPSALLO = "JPSALLO";

        /// <summary>
        /// JPSALHI.
        /// </summary>
        public const string JPSALHI = "JPSALHI";

        /// <summary>
        /// JPPSTLOC.
        /// </summary>
        public const string JPPSTLOC = "JPPSTLOC";

        /// <summary>
        /// JPNOLOC.
        /// </summary>
        public const string JPNOLOC = "JPNOLOC";

        /// <summary>
        /// JPEMAL.
        /// </summary>
        public const string JPEMAL = "JPEMAL";

        /// <summary>
        /// JPREMAIL.
        /// </summary>
        public const string JPREMAIL = "JPREMAIL";

        /// <summary>
        /// JPAN8.
        /// </summary>
        public const string JPAN8 = "JPAN8";

        /// <summary>
        /// JPAEMAL.
        /// </summary>
        public const string JPAEMAL = "JPAEMAL";

        /// <summary>
        /// JPOTPS.
        /// </summary>
        public const string JPOTPS = "JPOTPS";

        /// <summary>
        /// JPJBCD.
        /// </summary>
        public const string JPJBCD = "JPJBCD";

        /// <summary>
        /// JPJBST.
        /// </summary>
        public const string JPJBST = "JPJBST";

        /// <summary>
        /// JPORMCU.
        /// </summary>
        public const string JPORMCU = "JPORMCU";

        /// <summary>
        /// JPPID.
        /// </summary>
        public const string JPPID = "JPPID";

        /// <summary>
        /// JPUSER.
        /// </summary>
        public const string JPUSER = "JPUSER";

        /// <summary>
        /// JPMKEY.
        /// </summary>
        public const string JPMKEY = "JPMKEY";

        /// <summary>
        /// JPUPMJ.
        /// </summary>
        public const string JPUPMJ = "JPUPMJ";

        /// <summary>
        /// JPUPMT.
        /// </summary>
        public const string JPUPMT = "JPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08470";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPPSTNO", "JPPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("JPPSTCAT", "JPPSTCAT", JdeDataType.String, 20),
        new JdeField("JPREQN", "JPREQN", JdeDataType.Numeric),
        new JdeField("JPPSTSTS", "JPPSTSTS", JdeDataType.String, 2),
        new JdeField("JPPSTDI", "JPPSTDI", JdeDataType.Numeric),
        new JdeField("JPPSTDEI", "JPPSTDEI", JdeDataType.Numeric),
        new JdeField("JPPSTDE", "JPPSTDE", JdeDataType.Numeric),
        new JdeField("JPPSTDEE", "JPPSTDEE", JdeDataType.Numeric),
        new JdeField("JPSALLO", "JPSALLO", JdeDataType.Numeric),
        new JdeField("JPSALHI", "JPSALHI", JdeDataType.Numeric),
        new JdeField("JPPSTLOC", "JPPSTLOC", JdeDataType.String, 6),
        new JdeField("JPNOLOC", "JPNOLOC", JdeDataType.Numeric),
        new JdeField("JPEMAL", "JPEMAL", JdeDataType.String, 512),
        new JdeField("JPREMAIL", "JPREMAIL", JdeDataType.String, 2),
        new JdeField("JPAN8", "JPAN8", JdeDataType.Numeric),
        new JdeField("JPAEMAL", "JPAEMAL", JdeDataType.String, 512),
        new JdeField("JPOTPS", "JPOTPS", JdeDataType.String, 6),
        new JdeField("JPJBCD", "JPJBCD", JdeDataType.String, 12),
        new JdeField("JPJBST", "JPJBST", JdeDataType.String, 8),
        new JdeField("JPORMCU", "JPORMCU", JdeDataType.String, 24),
        new JdeField("JPPID", "JPPID", JdeDataType.String, 20),
        new JdeField("JPUSER", "JPUSER", JdeDataType.String, 20),
        new JdeField("JPMKEY", "JPMKEY", JdeDataType.String, 30),
        new JdeField("JPUPMJ", "JPUPMJ", JdeDataType.Numeric),
        new JdeField("JPUPMT", "JPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08470_0", "Primary Key on JPPSTNO", new[] { "JPPSTNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08470_2", "Index on JPPSTNO, JPPSTCAT", new[] { "JPPSTNO", "JPPSTCAT" }),
        new JdeIndex("F08470_3", "Index on JPREQN", new[] { "JPREQN" })
    };
}
