using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J006W - .
/// </summary>
public class F09J006W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OAJVJOBS.
        /// </summary>
        public const string OAJVJOBS = "OAJVJOBS";

        /// <summary>
        /// OAJVNAME.
        /// </summary>
        public const string OAJVNAME = "OAJVNAME";

        /// <summary>
        /// OAMCU.
        /// </summary>
        public const string OAMCU = "OAMCU";

        /// <summary>
        /// OAMCUS.
        /// </summary>
        public const string OAMCUS = "OAMCUS";

        /// <summary>
        /// OAJVCO.
        /// </summary>
        public const string OAJVCO = "OAJVCO";

        /// <summary>
        /// OAJVMCO.
        /// </summary>
        public const string OAJVMCO = "OAJVMCO";

        /// <summary>
        /// OAJVDSC.
        /// </summary>
        public const string OAJVDSC = "OAJVDSC";

        /// <summary>
        /// OAANP.
        /// </summary>
        public const string OAANP = "OAANP";

        /// <summary>
        /// OAJVSTS.
        /// </summary>
        public const string OAJVSTS = "OAJVSTS";

        /// <summary>
        /// OACO.
        /// </summary>
        public const string OACO = "OACO";

        /// <summary>
        /// OADL01.
        /// </summary>
        public const string OADL01 = "OADL01";

        /// <summary>
        /// OAJVAPPR.
        /// </summary>
        public const string OAJVAPPR = "OAJVAPPR";

        /// <summary>
        /// OAJVRMCU.
        /// </summary>
        public const string OAJVRMCU = "OAJVRMCU";

        /// <summary>
        /// OAJVCOH.
        /// </summary>
        public const string OAJVCOH = "OAJVCOH";

        /// <summary>
        /// OAJVANOV.
        /// </summary>
        public const string OAJVANOV = "OAJVANOV";

        /// <summary>
        /// OAJVINDATE.
        /// </summary>
        public const string OAJVINDATE = "OAJVINDATE";

        /// <summary>
        /// OAATMCU.
        /// </summary>
        public const string OAATMCU = "OAATMCU";

        /// <summary>
        /// OARLMCUS.
        /// </summary>
        public const string OARLMCUS = "OARLMCUS";

        /// <summary>
        /// OAJVOVN.
        /// </summary>
        public const string OAJVOVN = "OAJVOVN";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAMKEY.
        /// </summary>
        public const string OAMKEY = "OAMKEY";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";
    }

    /// <inheritdoc />
    public override string TableName => "F09J006W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OAJVJOBS", "OAJVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OAJVNAME", "OAJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("OAMCU", "OAMCU", JdeDataType.String, 24, true, true),
        new JdeField("OAMCUS", "OAMCUS", JdeDataType.String, 24),
        new JdeField("OAJVCO", "OAJVCO", JdeDataType.String, 10),
        new JdeField("OAJVMCO", "OAJVMCO", JdeDataType.String, 10),
        new JdeField("OAJVDSC", "OAJVDSC", JdeDataType.String, 160),
        new JdeField("OAANP", "OAANP", JdeDataType.Numeric),
        new JdeField("OAJVSTS", "OAJVSTS", JdeDataType.String, 6),
        new JdeField("OACO", "OACO", JdeDataType.String, 10),
        new JdeField("OADL01", "OADL01", JdeDataType.String, 60),
        new JdeField("OAJVAPPR", "OAJVAPPR", JdeDataType.String, 2),
        new JdeField("OAJVRMCU", "OAJVRMCU", JdeDataType.String, 24),
        new JdeField("OAJVCOH", "OAJVCOH", JdeDataType.String, 2),
        new JdeField("OAJVANOV", "OAJVANOV", JdeDataType.String, 2),
        new JdeField("OAJVINDATE", "OAJVINDATE", JdeDataType.Numeric),
        new JdeField("OAATMCU", "OAATMCU", JdeDataType.String, 24),
        new JdeField("OARLMCUS", "OARLMCUS", JdeDataType.String, 24),
        new JdeField("OAJVOVN", "OAJVOVN", JdeDataType.String, 40),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAMKEY", "OAMKEY", JdeDataType.String, 30),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J006W_0", "Primary Key on OAJVJOBS, OAJVNAME, OAMCU", new[] { "OAJVJOBS", "OAJVNAME", "OAMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
