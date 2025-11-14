using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L017 - .
/// </summary>
public class FF30L017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMFSCID.
        /// </summary>
        public const string WMFSCID = "WMFSCID";

        /// <summary>
        /// WMDFMCU.
        /// </summary>
        public const string WMDFMCU = "WMDFMCU";

        /// <summary>
        /// WMDFMMCU.
        /// </summary>
        public const string WMDFMMCU = "WMDFMMCU";

        /// <summary>
        /// WMDFMCUW.
        /// </summary>
        public const string WMDFMCUW = "WMDFMCUW";

        /// <summary>
        /// WMLIC.
        /// </summary>
        public const string WMLIC = "WMLIC";

        /// <summary>
        /// WMBFPF.
        /// </summary>
        public const string WMBFPF = "WMBFPF";

        /// <summary>
        /// WMDFPILC.
        /// </summary>
        public const string WMDFPILC = "WMDFPILC";

        /// <summary>
        /// WMDFSETC.
        /// </summary>
        public const string WMDFSETC = "WMDFSETC";

        /// <summary>
        /// WMDFNOMA.
        /// </summary>
        public const string WMDFNOMA = "WMDFNOMA";

        /// <summary>
        /// WMDFQMAD.
        /// </summary>
        public const string WMDFQMAD = "WMDFQMAD";

        /// <summary>
        /// WMDFQUED.
        /// </summary>
        public const string WMDFQUED = "WMDFQUED";

        /// <summary>
        /// WMDFMOVD.
        /// </summary>
        public const string WMDFMOVD = "WMDFMOVD";

        /// <summary>
        /// WMDFWORE.
        /// </summary>
        public const string WMDFWORE = "WMDFWORE";

        /// <summary>
        /// WMDFWORU.
        /// </summary>
        public const string WMDFWORU = "WMDFWORU";

        /// <summary>
        /// WMURCD.
        /// </summary>
        public const string WMURCD = "WMURCD";

        /// <summary>
        /// WMURDT.
        /// </summary>
        public const string WMURDT = "WMURDT";

        /// <summary>
        /// WMURAT.
        /// </summary>
        public const string WMURAT = "WMURAT";

        /// <summary>
        /// WMURAB.
        /// </summary>
        public const string WMURAB = "WMURAB";

        /// <summary>
        /// WMURRF.
        /// </summary>
        public const string WMURRF = "WMURRF";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMMKEY.
        /// </summary>
        public const string WMMKEY = "WMMKEY";

        /// <summary>
        /// WMUUPMJ.
        /// </summary>
        public const string WMUUPMJ = "WMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMFSCID", "WMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMDFMCU", "WMDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WMDFMMCU", "WMDFMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WMDFMCUW", "WMDFMCUW", JdeDataType.String, 24),
        new JdeField("WMLIC", "WMLIC", JdeDataType.String, 2),
        new JdeField("WMBFPF", "WMBFPF", JdeDataType.String, 2),
        new JdeField("WMDFPILC", "WMDFPILC", JdeDataType.String, 2),
        new JdeField("WMDFSETC", "WMDFSETC", JdeDataType.Numeric),
        new JdeField("WMDFNOMA", "WMDFNOMA", JdeDataType.Numeric),
        new JdeField("WMDFQMAD", "WMDFQMAD", JdeDataType.Numeric),
        new JdeField("WMDFQUED", "WMDFQUED", JdeDataType.Numeric),
        new JdeField("WMDFMOVD", "WMDFMOVD", JdeDataType.Numeric),
        new JdeField("WMDFWORE", "WMDFWORE", JdeDataType.Numeric),
        new JdeField("WMDFWORU", "WMDFWORU", JdeDataType.Numeric),
        new JdeField("WMURCD", "WMURCD", JdeDataType.String, 4),
        new JdeField("WMURDT", "WMURDT", JdeDataType.Numeric),
        new JdeField("WMURAT", "WMURAT", JdeDataType.Numeric),
        new JdeField("WMURAB", "WMURAB", JdeDataType.Numeric),
        new JdeField("WMURRF", "WMURRF", JdeDataType.String, 30),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMMKEY", "WMMKEY", JdeDataType.String, 30),
        new JdeField("WMUUPMJ", "WMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L017_0", "Primary Key on WMFSCID, WMDFMCU, WMDFMMCU", new[] { "WMFSCID", "WMDFMCU", "WMDFMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
