using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1521D - .
/// </summary>
public class F1521D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBLGNM.
        /// </summary>
        public const string NBLGNM = "NBLGNM";

        /// <summary>
        /// NBLNGP.
        /// </summary>
        public const string NBLNGP = "NBLNGP";

        /// <summary>
        /// NBDL01.
        /// </summary>
        public const string NBDL01 = "NBDL01";

        /// <summary>
        /// NBEXR.
        /// </summary>
        public const string NBEXR = "NBEXR";

        /// <summary>
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBPID.
        /// </summary>
        public const string NBPID = "NBPID";

        /// <summary>
        /// NBUPMJ.
        /// </summary>
        public const string NBUPMJ = "NBUPMJ";

        /// <summary>
        /// NBUPMT.
        /// </summary>
        public const string NBUPMT = "NBUPMT";

        /// <summary>
        /// NBJOBN.
        /// </summary>
        public const string NBJOBN = "NBJOBN";

        /// <summary>
        /// NBTORG.
        /// </summary>
        public const string NBTORG = "NBTORG";

        /// <summary>
        /// NBENTJ.
        /// </summary>
        public const string NBENTJ = "NBENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1521D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBLGNM", "NBLGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("NBLNGP", "NBLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NBDL01", "NBDL01", JdeDataType.String, 60),
        new JdeField("NBEXR", "NBEXR", JdeDataType.String, 60),
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20),
        new JdeField("NBPID", "NBPID", JdeDataType.String, 20),
        new JdeField("NBUPMJ", "NBUPMJ", JdeDataType.Numeric),
        new JdeField("NBUPMT", "NBUPMT", JdeDataType.Numeric),
        new JdeField("NBJOBN", "NBJOBN", JdeDataType.String, 20),
        new JdeField("NBTORG", "NBTORG", JdeDataType.String, 20),
        new JdeField("NBENTJ", "NBENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1521D_0", "Primary Key on NBLGNM, NBLNGP", new[] { "NBLGNM", "NBLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
