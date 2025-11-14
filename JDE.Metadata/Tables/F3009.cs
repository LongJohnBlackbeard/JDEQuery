using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3009 - .
/// </summary>
public class F3009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IASY.
        /// </summary>
        public const string IASY = "IASY";

        /// <summary>
        /// IAMMCU.
        /// </summary>
        public const string IAMMCU = "IAMMCU";

        /// <summary>
        /// IADORS.
        /// </summary>
        public const string IADORS = "IADORS";

        /// <summary>
        /// IAMAXL.
        /// </summary>
        public const string IAMAXL = "IAMAXL";

        /// <summary>
        /// IALOGB.
        /// </summary>
        public const string IALOGB = "IALOGB";

        /// <summary>
        /// IAPORR.
        /// </summary>
        public const string IAPORR = "IAPORR";

        /// <summary>
        /// IAMWCE.
        /// </summary>
        public const string IAMWCE = "IAMWCE";

        /// <summary>
        /// IAIVO.
        /// </summary>
        public const string IAIVO = "IAIVO";

        /// <summary>
        /// IACVDL.
        /// </summary>
        public const string IACVDL = "IACVDL";

        /// <summary>
        /// IACVSL.
        /// </summary>
        public const string IACVSL = "IACVSL";

        /// <summary>
        /// IACVDS.
        /// </summary>
        public const string IACVDS = "IACVDS";

        /// <summary>
        /// IAIFO.
        /// </summary>
        public const string IAIFO = "IAIFO";

        /// <summary>
        /// IACFDL.
        /// </summary>
        public const string IACFDL = "IACFDL";

        /// <summary>
        /// IACFSL.
        /// </summary>
        public const string IACFSL = "IACFSL";

        /// <summary>
        /// IACFDS.
        /// </summary>
        public const string IACFDS = "IACFDS";

        /// <summary>
        /// IAIVMO.
        /// </summary>
        public const string IAIVMO = "IAIVMO";

        /// <summary>
        /// IAIFMO.
        /// </summary>
        public const string IAIFMO = "IAIFMO";

        /// <summary>
        /// IABFOP.
        /// </summary>
        public const string IABFOP = "IABFOP";

        /// <summary>
        /// IAMRYN.
        /// </summary>
        public const string IAMRYN = "IAMRYN";

        /// <summary>
        /// IAWRHR.
        /// </summary>
        public const string IAWRHR = "IAWRHR";

        /// <summary>
        /// IAFLD1.
        /// </summary>
        public const string IAFLD1 = "IAFLD1";

        /// <summary>
        /// IAFLD2.
        /// </summary>
        public const string IAFLD2 = "IAFLD2";

        /// <summary>
        /// IAFLD3.
        /// </summary>
        public const string IAFLD3 = "IAFLD3";

        /// <summary>
        /// IAFLD4.
        /// </summary>
        public const string IAFLD4 = "IAFLD4";

        /// <summary>
        /// IAFLD5.
        /// </summary>
        public const string IAFLD5 = "IAFLD5";

        /// <summary>
        /// IAUSER.
        /// </summary>
        public const string IAUSER = "IAUSER";

        /// <summary>
        /// IAPID.
        /// </summary>
        public const string IAPID = "IAPID";

        /// <summary>
        /// IAUPMJ.
        /// </summary>
        public const string IAUPMJ = "IAUPMJ";

        /// <summary>
        /// IAJOBN.
        /// </summary>
        public const string IAJOBN = "IAJOBN";

        /// <summary>
        /// IAWRH2.
        /// </summary>
        public const string IAWRH2 = "IAWRH2";

        /// <summary>
        /// IAWRH3.
        /// </summary>
        public const string IAWRH3 = "IAWRH3";

        /// <summary>
        /// IAWRH4.
        /// </summary>
        public const string IAWRH4 = "IAWRH4";

        /// <summary>
        /// IAWRH5.
        /// </summary>
        public const string IAWRH5 = "IAWRH5";

        /// <summary>
        /// IAWRH6.
        /// </summary>
        public const string IAWRH6 = "IAWRH6";

        /// <summary>
        /// IASHFT.
        /// </summary>
        public const string IASHFT = "IASHFT";

        /// <summary>
        /// IASHF2.
        /// </summary>
        public const string IASHF2 = "IASHF2";

        /// <summary>
        /// IASHF3.
        /// </summary>
        public const string IASHF3 = "IASHF3";

        /// <summary>
        /// IASHF4.
        /// </summary>
        public const string IASHF4 = "IASHF4";

        /// <summary>
        /// IASHF5.
        /// </summary>
        public const string IASHF5 = "IASHF5";

        /// <summary>
        /// IASHF6.
        /// </summary>
        public const string IASHF6 = "IASHF6";

        /// <summary>
        /// IAPBVD.
        /// </summary>
        public const string IAPBVD = "IAPBVD";

        /// <summary>
        /// IASRS1.
        /// </summary>
        public const string IASRS1 = "IASRS1";

        /// <summary>
        /// IAURDT.
        /// </summary>
        public const string IAURDT = "IAURDT";

        /// <summary>
        /// IAURAT.
        /// </summary>
        public const string IAURAT = "IAURAT";

        /// <summary>
        /// IAURAB.
        /// </summary>
        public const string IAURAB = "IAURAB";

        /// <summary>
        /// IAURRF.
        /// </summary>
        public const string IAURRF = "IAURRF";

        /// <summary>
        /// IAURCD.
        /// </summary>
        public const string IAURCD = "IAURCD";

        /// <summary>
        /// IAMARS.
        /// </summary>
        public const string IAMARS = "IAMARS";

        /// <summary>
        /// IALARS.
        /// </summary>
        public const string IALARS = "IALARS";

        /// <summary>
        /// IACWC.
        /// </summary>
        public const string IACWC = "IACWC";

        /// <summary>
        /// IAWOAR.
        /// </summary>
        public const string IAWOAR = "IAWOAR";
    }

    /// <inheritdoc />
    public override string TableName => "F3009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IASY", "IASY", JdeDataType.String, 8),
        new JdeField("IAMMCU", "IAMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IADORS", "IADORS", JdeDataType.String, 2),
        new JdeField("IAMAXL", "IAMAXL", JdeDataType.Numeric),
        new JdeField("IALOGB", "IALOGB", JdeDataType.String, 2),
        new JdeField("IAPORR", "IAPORR", JdeDataType.String, 2),
        new JdeField("IAMWCE", "IAMWCE", JdeDataType.String, 2),
        new JdeField("IAIVO", "IAIVO", JdeDataType.String, 2),
        new JdeField("IACVDL", "IACVDL", JdeDataType.String, 2),
        new JdeField("IACVSL", "IACVSL", JdeDataType.String, 2),
        new JdeField("IACVDS", "IACVDS", JdeDataType.String, 2),
        new JdeField("IAIFO", "IAIFO", JdeDataType.String, 2),
        new JdeField("IACFDL", "IACFDL", JdeDataType.String, 2),
        new JdeField("IACFSL", "IACFSL", JdeDataType.String, 2),
        new JdeField("IACFDS", "IACFDS", JdeDataType.String, 2),
        new JdeField("IAIVMO", "IAIVMO", JdeDataType.String, 2),
        new JdeField("IAIFMO", "IAIFMO", JdeDataType.String, 2),
        new JdeField("IABFOP", "IABFOP", JdeDataType.String, 2),
        new JdeField("IAMRYN", "IAMRYN", JdeDataType.String, 2),
        new JdeField("IAWRHR", "IAWRHR", JdeDataType.Numeric),
        new JdeField("IAFLD1", "IAFLD1", JdeDataType.String, 2),
        new JdeField("IAFLD2", "IAFLD2", JdeDataType.String, 2),
        new JdeField("IAFLD3", "IAFLD3", JdeDataType.String, 2),
        new JdeField("IAFLD4", "IAFLD4", JdeDataType.String, 2),
        new JdeField("IAFLD5", "IAFLD5", JdeDataType.String, 2),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAUPMJ", "IAUPMJ", JdeDataType.Numeric),
        new JdeField("IAJOBN", "IAJOBN", JdeDataType.String, 20),
        new JdeField("IAWRH2", "IAWRH2", JdeDataType.Numeric),
        new JdeField("IAWRH3", "IAWRH3", JdeDataType.Numeric),
        new JdeField("IAWRH4", "IAWRH4", JdeDataType.Numeric),
        new JdeField("IAWRH5", "IAWRH5", JdeDataType.Numeric),
        new JdeField("IAWRH6", "IAWRH6", JdeDataType.Numeric),
        new JdeField("IASHFT", "IASHFT", JdeDataType.String, 2),
        new JdeField("IASHF2", "IASHF2", JdeDataType.String, 2),
        new JdeField("IASHF3", "IASHF3", JdeDataType.String, 2),
        new JdeField("IASHF4", "IASHF4", JdeDataType.String, 2),
        new JdeField("IASHF5", "IASHF5", JdeDataType.String, 2),
        new JdeField("IASHF6", "IASHF6", JdeDataType.String, 2),
        new JdeField("IAPBVD", "IAPBVD", JdeDataType.String, 2),
        new JdeField("IASRS1", "IASRS1", JdeDataType.String, 4),
        new JdeField("IAURDT", "IAURDT", JdeDataType.Numeric),
        new JdeField("IAURAT", "IAURAT", JdeDataType.Numeric),
        new JdeField("IAURAB", "IAURAB", JdeDataType.Numeric),
        new JdeField("IAURRF", "IAURRF", JdeDataType.String, 30),
        new JdeField("IAURCD", "IAURCD", JdeDataType.String, 4),
        new JdeField("IAMARS", "IAMARS", JdeDataType.String, 2),
        new JdeField("IALARS", "IALARS", JdeDataType.String, 2),
        new JdeField("IACWC", "IACWC", JdeDataType.String, 2),
        new JdeField("IAWOAR", "IAWOAR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3009_0", "Primary Key on IAMMCU", new[] { "IAMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
