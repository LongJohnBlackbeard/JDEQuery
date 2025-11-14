using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980046 - .
/// </summary>
public class F980046 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTMMCTMPI.
        /// </summary>
        public const string CTMMCTMPI = "CTMMCTMPI";

        /// <summary>
        /// CTDESC.
        /// </summary>
        public const string CTDESC = "CTDESC";

        /// <summary>
        /// CTCRTU.
        /// </summary>
        public const string CTCRTU = "CTCRTU";

        /// <summary>
        /// CTSY.
        /// </summary>
        public const string CTSY = "CTSY";

        /// <summary>
        /// CTACTSTS.
        /// </summary>
        public const string CTACTSTS = "CTACTSTS";

        /// <summary>
        /// CTGRPROLE.
        /// </summary>
        public const string CTGRPROLE = "CTGRPROLE";

        /// <summary>
        /// CTCDAA.
        /// </summary>
        public const string CTCDAA = "CTCDAA";

        /// <summary>
        /// CTCDBB.
        /// </summary>
        public const string CTCDBB = "CTCDBB";

        /// <summary>
        /// CTCDCC.
        /// </summary>
        public const string CTCDCC = "CTCDCC";

        /// <summary>
        /// CTFNDFUF1.
        /// </summary>
        public const string CTFNDFUF1 = "CTFNDFUF1";

        /// <summary>
        /// CTFNDFUF2.
        /// </summary>
        public const string CTFNDFUF2 = "CTFNDFUF2";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F980046";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTMMCTMPI", "CTMMCTMPI", JdeDataType.String, 20, true, true),
        new JdeField("CTDESC", "CTDESC", JdeDataType.String, 60),
        new JdeField("CTCRTU", "CTCRTU", JdeDataType.String, 20),
        new JdeField("CTSY", "CTSY", JdeDataType.String, 8),
        new JdeField("CTACTSTS", "CTACTSTS", JdeDataType.String, 4),
        new JdeField("CTGRPROLE", "CTGRPROLE", JdeDataType.String, 30),
        new JdeField("CTCDAA", "CTCDAA", JdeDataType.String, 4),
        new JdeField("CTCDBB", "CTCDBB", JdeDataType.String, 4),
        new JdeField("CTCDCC", "CTCDCC", JdeDataType.String, 4),
        new JdeField("CTFNDFUF1", "CTFNDFUF1", JdeDataType.String, 60),
        new JdeField("CTFNDFUF2", "CTFNDFUF2", JdeDataType.String, 60),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980046_0", "Primary Key on CTMMCTMPI", new[] { "CTMMCTMPI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F980046_2", "Index on CTACTSTS, CTCRTU", new[] { "CTACTSTS", "CTCRTU" })
    };
}
