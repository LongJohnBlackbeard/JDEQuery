using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1316 - .
/// </summary>
public class F1316 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMITYPE.
        /// </summary>
        public const string CMITYPE = "CMITYPE";

        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMLANO.
        /// </summary>
        public const string CMLANO = "CMLANO";

        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMLOC.
        /// </summary>
        public const string CMLOC = "CMLOC";

        /// <summary>
        /// CMPRODF.
        /// </summary>
        public const string CMPRODF = "CMPRODF";

        /// <summary>
        /// CMPRODM.
        /// </summary>
        public const string CMPRODM = "CMPRODM";

        /// <summary>
        /// CMNUMB.
        /// </summary>
        public const string CMNUMB = "CMNUMB";

        /// <summary>
        /// CMITM.
        /// </summary>
        public const string CMITM = "CMITM";

        /// <summary>
        /// CMPDFL.
        /// </summary>
        public const string CMPDFL = "CMPDFL";

        /// <summary>
        /// CMNOTR.
        /// </summary>
        public const string CMNOTR = "CMNOTR";

        /// <summary>
        /// CMNSTT.
        /// </summary>
        public const string CMNSTT = "CMNSTT";

        /// <summary>
        /// CMINVR.
        /// </summary>
        public const string CMINVR = "CMINVR";

        /// <summary>
        /// CMISTT.
        /// </summary>
        public const string CMISTT = "CMISTT";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1316";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMITYPE", "CMITYPE", JdeDataType.String, 2, true, true),
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CMLANO", "CMLANO", JdeDataType.Numeric, null, true, true),
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CMLOC", "CMLOC", JdeDataType.String, 24, true, true),
        new JdeField("CMPRODF", "CMPRODF", JdeDataType.String, 16, true, true),
        new JdeField("CMPRODM", "CMPRODM", JdeDataType.String, 16, true, true),
        new JdeField("CMNUMB", "CMNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("CMITM", "CMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CMPDFL", "CMPDFL", JdeDataType.String, 2, true, true),
        new JdeField("CMNOTR", "CMNOTR", JdeDataType.Numeric),
        new JdeField("CMNSTT", "CMNSTT", JdeDataType.String, 6),
        new JdeField("CMINVR", "CMINVR", JdeDataType.Numeric),
        new JdeField("CMISTT", "CMISTT", JdeDataType.String, 6),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1316_0", "Primary Key on CMITYPE, CMAN8, CMLANO, CMMCU, CMLOC, CMPRODF, CMPRODM, CMNUMB, CMITM, CMPDFL", new[] { "CMITYPE", "CMAN8", "CMLANO", "CMMCU", "CMLOC", "CMPRODF", "CMPRODM", "CMNUMB", "CMITM", "CMPDFL" }, isUnique: true, isPrimaryKey: true)
    };
}
