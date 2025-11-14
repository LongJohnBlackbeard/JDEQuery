using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980045 - .
/// </summary>
public class F980045 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STMMTMPI.
        /// </summary>
        public const string STMMTMPI = "STMMTMPI";

        /// <summary>
        /// STDESC.
        /// </summary>
        public const string STDESC = "STDESC";

        /// <summary>
        /// STCRTU.
        /// </summary>
        public const string STCRTU = "STCRTU";

        /// <summary>
        /// STSY.
        /// </summary>
        public const string STSY = "STSY";

        /// <summary>
        /// STEDSNM.
        /// </summary>
        public const string STEDSNM = "STEDSNM";

        /// <summary>
        /// STACTTYPE.
        /// </summary>
        public const string STACTTYPE = "STACTTYPE";

        /// <summary>
        /// STACTSTS.
        /// </summary>
        public const string STACTSTS = "STACTSTS";

        /// <summary>
        /// STGRPROLE.
        /// </summary>
        public const string STGRPROLE = "STGRPROLE";

        /// <summary>
        /// STCDAA.
        /// </summary>
        public const string STCDAA = "STCDAA";

        /// <summary>
        /// STCDBB.
        /// </summary>
        public const string STCDBB = "STCDBB";

        /// <summary>
        /// STCDCC.
        /// </summary>
        public const string STCDCC = "STCDCC";

        /// <summary>
        /// STFNDFUF1.
        /// </summary>
        public const string STFNDFUF1 = "STFNDFUF1";

        /// <summary>
        /// STFNDFUF2.
        /// </summary>
        public const string STFNDFUF2 = "STFNDFUF2";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F980045";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STMMTMPI", "STMMTMPI", JdeDataType.String, 20, true, true),
        new JdeField("STDESC", "STDESC", JdeDataType.String, 60),
        new JdeField("STCRTU", "STCRTU", JdeDataType.String, 20),
        new JdeField("STSY", "STSY", JdeDataType.String, 8),
        new JdeField("STEDSNM", "STEDSNM", JdeDataType.String, 22),
        new JdeField("STACTTYPE", "STACTTYPE", JdeDataType.String, 4),
        new JdeField("STACTSTS", "STACTSTS", JdeDataType.String, 4),
        new JdeField("STGRPROLE", "STGRPROLE", JdeDataType.String, 30),
        new JdeField("STCDAA", "STCDAA", JdeDataType.String, 4),
        new JdeField("STCDBB", "STCDBB", JdeDataType.String, 4),
        new JdeField("STCDCC", "STCDCC", JdeDataType.String, 4),
        new JdeField("STFNDFUF1", "STFNDFUF1", JdeDataType.String, 60),
        new JdeField("STFNDFUF2", "STFNDFUF2", JdeDataType.String, 60),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980045_0", "Primary Key on STMMTMPI", new[] { "STMMTMPI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F980045_2", "Index on STACTSTS, STCRTU", new[] { "STACTSTS", "STCRTU" }),
        new JdeIndex("F980045_3", "Index on STEDSNM", new[] { "STEDSNM" })
    };
}
