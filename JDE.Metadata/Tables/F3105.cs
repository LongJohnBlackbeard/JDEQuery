using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3105 - .
/// </summary>
public class F3105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISDOCO.
        /// </summary>
        public const string ISDOCO = "ISDOCO";

        /// <summary>
        /// ISDCT.
        /// </summary>
        public const string ISDCT = "ISDCT";

        /// <summary>
        /// ISMCU.
        /// </summary>
        public const string ISMCU = "ISMCU";

        /// <summary>
        /// ISLINS.
        /// </summary>
        public const string ISLINS = "ISLINS";

        /// <summary>
        /// ISLOTN.
        /// </summary>
        public const string ISLOTN = "ISLOTN";

        /// <summary>
        /// ISLOT1.
        /// </summary>
        public const string ISLOT1 = "ISLOT1";

        /// <summary>
        /// ISLOT2.
        /// </summary>
        public const string ISLOT2 = "ISLOT2";

        /// <summary>
        /// ISLOCN.
        /// </summary>
        public const string ISLOCN = "ISLOCN";

        /// <summary>
        /// ISQNTY.
        /// </summary>
        public const string ISQNTY = "ISQNTY";

        /// <summary>
        /// ISLITM.
        /// </summary>
        public const string ISLITM = "ISLITM";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F3105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISDOCO", "ISDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDCT", "ISDCT", JdeDataType.String, 4, true, true),
        new JdeField("ISMCU", "ISMCU", JdeDataType.String, 24, true, true),
        new JdeField("ISLINS", "ISLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("ISLOTN", "ISLOTN", JdeDataType.String, 60),
        new JdeField("ISLOT1", "ISLOT1", JdeDataType.String, 60),
        new JdeField("ISLOT2", "ISLOT2", JdeDataType.String, 60),
        new JdeField("ISLOCN", "ISLOCN", JdeDataType.String, 40),
        new JdeField("ISQNTY", "ISQNTY", JdeDataType.Numeric),
        new JdeField("ISLITM", "ISLITM", JdeDataType.String, 50),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3105_0", "Primary Key on ISDOCO, ISDCT, ISMCU, ISLINS", new[] { "ISDOCO", "ISDCT", "ISMCU", "ISLINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3105_2", "Index on ISMCU, ISDCT, ISDOCO, ISLOTN", new[] { "ISMCU", "ISDCT", "ISDOCO", "ISLOTN" }),
        new JdeIndex("F3105_3", "Index on ISLOTN", new[] { "ISLOTN" }),
        new JdeIndex("F3105_4", "Index on ISLOT2", new[] { "ISLOT2" }),
        new JdeIndex("F3105_5", "Index on ISDOCO, ISLOT2, ISLOT1, ISLINS", new[] { "ISDOCO", "ISLOT2", "ISLOT1", "ISLINS" }),
        new JdeIndex("F3105_6", "Index on ISDOCO, ISDCT, SYS_NC00016$", new[] { "ISDOCO", "ISDCT", "SYS_NC00016$" })
    };
}
