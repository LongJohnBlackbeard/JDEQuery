using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1759 - .
/// </summary>
public class F1759 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLFILE.
        /// </summary>
        public const string CLFILE = "CLFILE";

        /// <summary>
        /// CLDCTO.
        /// </summary>
        public const string CLDCTO = "CLDCTO";

        /// <summary>
        /// CLCALLQ.
        /// </summary>
        public const string CLCALLQ = "CLCALLQ";

        /// <summary>
        /// CLCT01.
        /// </summary>
        public const string CLCT01 = "CLCT01";

        /// <summary>
        /// CLCLST.
        /// </summary>
        public const string CLCLST = "CLCLST";

        /// <summary>
        /// CLDTAI.
        /// </summary>
        public const string CLDTAI = "CLDTAI";

        /// <summary>
        /// CLCRTU.
        /// </summary>
        public const string CLCRTU = "CLCRTU";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLJOBN.
        /// </summary>
        public const string CLJOBN = "CLJOBN";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1759";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLFILE", "CLFILE", JdeDataType.String, 20, true, true),
        new JdeField("CLDCTO", "CLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CLCALLQ", "CLCALLQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CLCT01", "CLCT01", JdeDataType.String, 2, true, true),
        new JdeField("CLCLST", "CLCLST", JdeDataType.String, 6, true, true),
        new JdeField("CLDTAI", "CLDTAI", JdeDataType.String, 20, true, true),
        new JdeField("CLCRTU", "CLCRTU", JdeDataType.String, 20),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1759_0", "Primary Key on CLFILE, CLDCTO, CLCALLQ, CLCT01, CLCLST, CLDTAI", new[] { "CLFILE", "CLDCTO", "CLCALLQ", "CLCT01", "CLCLST", "CLDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
