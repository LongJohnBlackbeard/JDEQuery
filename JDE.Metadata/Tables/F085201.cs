using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085201 - .
/// </summary>
public class F085201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HKPLAN.
        /// </summary>
        public const string HKPLAN = "HKPLAN";

        /// <summary>
        /// HKBPY.
        /// </summary>
        public const string HKBPY = "HKBPY";

        /// <summary>
        /// HKBSPT.
        /// </summary>
        public const string HKBSPT = "HKBSPT";

        /// <summary>
        /// HKTCBS.
        /// </summary>
        public const string HKTCBS = "HKTCBS";

        /// <summary>
        /// HKBSSH.
        /// </summary>
        public const string HKBSSH = "HKBSSH";

        /// <summary>
        /// HKMISC.
        /// </summary>
        public const string HKMISC = "HKMISC";

        /// <summary>
        /// HKMASC.
        /// </summary>
        public const string HKMASC = "HKMASC";

        /// <summary>
        /// HKIOS.
        /// </summary>
        public const string HKIOS = "HKIOS";

        /// <summary>
        /// HKERL.
        /// </summary>
        public const string HKERL = "HKERL";

        /// <summary>
        /// HKNRL.
        /// </summary>
        public const string HKNRL = "HKNRL";

        /// <summary>
        /// HKRDR.
        /// </summary>
        public const string HKRDR = "HKRDR";

        /// <summary>
        /// HKABF1.
        /// </summary>
        public const string HKABF1 = "HKABF1";

        /// <summary>
        /// HKABF2.
        /// </summary>
        public const string HKABF2 = "HKABF2";

        /// <summary>
        /// HKABF3.
        /// </summary>
        public const string HKABF3 = "HKABF3";

        /// <summary>
        /// HKABF4.
        /// </summary>
        public const string HKABF4 = "HKABF4";

        /// <summary>
        /// HKABF5.
        /// </summary>
        public const string HKABF5 = "HKABF5";

        /// <summary>
        /// HKAPH.
        /// </summary>
        public const string HKAPH = "HKAPH";

        /// <summary>
        /// HKTCVS.
        /// </summary>
        public const string HKTCVS = "HKTCVS";

        /// <summary>
        /// HKUSER.
        /// </summary>
        public const string HKUSER = "HKUSER";

        /// <summary>
        /// HKPID.
        /// </summary>
        public const string HKPID = "HKPID";

        /// <summary>
        /// HKUPMJ.
        /// </summary>
        public const string HKUPMJ = "HKUPMJ";

        /// <summary>
        /// HKJOBN.
        /// </summary>
        public const string HKJOBN = "HKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F085201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HKPLAN", "HKPLAN", JdeDataType.String, 16, true, true),
        new JdeField("HKBPY", "HKBPY", JdeDataType.Numeric),
        new JdeField("HKBSPT", "HKBSPT", JdeDataType.String, 8),
        new JdeField("HKTCBS", "HKTCBS", JdeDataType.Numeric),
        new JdeField("HKBSSH", "HKBSSH", JdeDataType.Numeric),
        new JdeField("HKMISC", "HKMISC", JdeDataType.Numeric),
        new JdeField("HKMASC", "HKMASC", JdeDataType.Numeric),
        new JdeField("HKIOS", "HKIOS", JdeDataType.String, 2),
        new JdeField("HKERL", "HKERL", JdeDataType.String, 8),
        new JdeField("HKNRL", "HKNRL", JdeDataType.String, 8),
        new JdeField("HKRDR", "HKRDR", JdeDataType.String, 8),
        new JdeField("HKABF1", "HKABF1", JdeDataType.Numeric),
        new JdeField("HKABF2", "HKABF2", JdeDataType.Numeric),
        new JdeField("HKABF3", "HKABF3", JdeDataType.Numeric),
        new JdeField("HKABF4", "HKABF4", JdeDataType.Numeric),
        new JdeField("HKABF5", "HKABF5", JdeDataType.Numeric),
        new JdeField("HKAPH", "HKAPH", JdeDataType.String, 2),
        new JdeField("HKTCVS", "HKTCVS", JdeDataType.Numeric),
        new JdeField("HKUSER", "HKUSER", JdeDataType.String, 20),
        new JdeField("HKPID", "HKPID", JdeDataType.String, 20),
        new JdeField("HKUPMJ", "HKUPMJ", JdeDataType.Numeric),
        new JdeField("HKJOBN", "HKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085201_0", "Primary Key on HKPLAN", new[] { "HKPLAN" }, isUnique: true, isPrimaryKey: true)
    };
}
