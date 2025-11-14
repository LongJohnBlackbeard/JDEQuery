using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96450 - .
/// </summary>
public class F96450 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECEEN.
        /// </summary>
        public const string ECEEN = "ECEEN";

        /// <summary>
        /// ECETVAL.
        /// </summary>
        public const string ECETVAL = "ECETVAL";

        /// <summary>
        /// ECEREV.
        /// </summary>
        public const string ECEREV = "ECEREV";

        /// <summary>
        /// ECCDFUSTR1.
        /// </summary>
        public const string ECCDFUSTR1 = "ECCDFUSTR1";

        /// <summary>
        /// ECCDFUSTR2.
        /// </summary>
        public const string ECCDFUSTR2 = "ECCDFUSTR2";

        /// <summary>
        /// ECCDFUNUM.
        /// </summary>
        public const string ECCDFUNUM = "ECCDFUNUM";

        /// <summary>
        /// ECCDFUMJ.
        /// </summary>
        public const string ECCDFUMJ = "ECCDFUMJ";

        /// <summary>
        /// ECCDFUCHAR.
        /// </summary>
        public const string ECCDFUCHAR = "ECCDFUCHAR";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96450";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECEEN", "ECEEN", JdeDataType.String, 2),
        new JdeField("ECETVAL", "ECETVAL", JdeDataType.String, 20, true, true),
        new JdeField("ECEREV", "ECEREV", JdeDataType.String, 20),
        new JdeField("ECCDFUSTR1", "ECCDFUSTR1", JdeDataType.String, 20),
        new JdeField("ECCDFUSTR2", "ECCDFUSTR2", JdeDataType.String, 20),
        new JdeField("ECCDFUNUM", "ECCDFUNUM", JdeDataType.Numeric),
        new JdeField("ECCDFUMJ", "ECCDFUMJ", JdeDataType.Numeric),
        new JdeField("ECCDFUCHAR", "ECCDFUCHAR", JdeDataType.String, 2),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96450_0", "Primary Key on ECETVAL", new[] { "ECETVAL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F96450_2", "Index on ECEEN", new[] { "ECEEN" })
    };
}
