using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B40 - .
/// </summary>
public class F76B40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSCO.
        /// </summary>
        public const string MSCO = "MSCO";

        /// <summary>
        /// MSBRINM.
        /// </summary>
        public const string MSBRINM = "MSBRINM";

        /// <summary>
        /// MSBRDCTP.
        /// </summary>
        public const string MSBRDCTP = "MSBRDCTP";

        /// <summary>
        /// MSBRSSR.
        /// </summary>
        public const string MSBRSSR = "MSBRSSR";

        /// <summary>
        /// MSBRNNF.
        /// </summary>
        public const string MSBRNNF = "MSBRNNF";

        /// <summary>
        /// MSDTDO.
        /// </summary>
        public const string MSDTDO = "MSDTDO";

        /// <summary>
        /// MSAT1.
        /// </summary>
        public const string MSAT1 = "MSAT1";

        /// <summary>
        /// MSAN8.
        /// </summary>
        public const string MSAN8 = "MSAN8";

        /// <summary>
        /// MSINC.
        /// </summary>
        public const string MSINC = "MSINC";

        /// <summary>
        /// MSBRDTM.
        /// </summary>
        public const string MSBRDTM = "MSBRDTM";

        /// <summary>
        /// MSACTAA.
        /// </summary>
        public const string MSACTAA = "MSACTAA";

        /// <summary>
        /// MSDSCT.
        /// </summary>
        public const string MSDSCT = "MSDSCT";

        /// <summary>
        /// MSBRPCIR.
        /// </summary>
        public const string MSBRPCIR = "MSBRPCIR";

        /// <summary>
        /// MSBRBSIR.
        /// </summary>
        public const string MSBRBSIR = "MSBRBSIR";

        /// <summary>
        /// MSBRTTIR.
        /// </summary>
        public const string MSBRTTIR = "MSBRTTIR";

        /// <summary>
        /// MSCSLF.
        /// </summary>
        public const string MSCSLF = "MSCSLF";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSEAP.
        /// </summary>
        public const string MSEAP = "MSEAP";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MSUPMT.
        /// </summary>
        public const string MSUPMT = "MSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSCO", "MSCO", JdeDataType.String, 10, true, true),
        new JdeField("MSBRINM", "MSBRINM", JdeDataType.String, 2, true, true),
        new JdeField("MSBRDCTP", "MSBRDCTP", JdeDataType.String, 6),
        new JdeField("MSBRSSR", "MSBRSSR", JdeDataType.String, 10, true, true),
        new JdeField("MSBRNNF", "MSBRNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("MSDTDO", "MSDTDO", JdeDataType.Numeric),
        new JdeField("MSAT1", "MSAT1", JdeDataType.String, 6, true, true),
        new JdeField("MSAN8", "MSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MSINC", "MSINC", JdeDataType.String, 2),
        new JdeField("MSBRDTM", "MSBRDTM", JdeDataType.String, 4),
        new JdeField("MSACTAA", "MSACTAA", JdeDataType.Numeric),
        new JdeField("MSDSCT", "MSDSCT", JdeDataType.Numeric),
        new JdeField("MSBRPCIR", "MSBRPCIR", JdeDataType.Numeric),
        new JdeField("MSBRBSIR", "MSBRBSIR", JdeDataType.Numeric),
        new JdeField("MSBRTTIR", "MSBRTTIR", JdeDataType.Numeric),
        new JdeField("MSCSLF", "MSCSLF", JdeDataType.String, 2),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSEAP", "MSEAP", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MSUPMT", "MSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B40_0", "Primary Key on MSCO, MSBRINM, MSBRSSR, MSBRNNF, MSAT1, MSAN8", new[] { "MSCO", "MSBRINM", "MSBRSSR", "MSBRNNF", "MSAT1", "MSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
