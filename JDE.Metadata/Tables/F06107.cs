using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06107 - .
/// </summary>
public class F06107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J$AN8.
        /// </summary>
        public const string J_AN8 = "J$AN8";

        /// <summary>
        /// J$PDBA.
        /// </summary>
        public const string J_PDBA = "J$PDBA";

        /// <summary>
        /// J$WANO.
        /// </summary>
        public const string J_WANO = "J$WANO";

        /// <summary>
        /// J$WAP1.
        /// </summary>
        public const string J_WAP1 = "J$WAP1";

        /// <summary>
        /// J$WAP2.
        /// </summary>
        public const string J_WAP2 = "J$WAP2";

        /// <summary>
        /// J$WAFC.
        /// </summary>
        public const string J_WAFC = "J$WAFC";

        /// <summary>
        /// J$WAAL.
        /// </summary>
        public const string J_WAAL = "J$WAAL";

        /// <summary>
        /// J$WAAP.
        /// </summary>
        public const string J_WAAP = "J$WAAP";

        /// <summary>
        /// J$OAN8.
        /// </summary>
        public const string J_OAN8 = "J$OAN8";

        /// <summary>
        /// J$WAAA.
        /// </summary>
        public const string J_WAAA = "J$WAAA";

        /// <summary>
        /// J$TARA.
        /// </summary>
        public const string J_TARA = "J$TARA";

        /// <summary>
        /// J$PTCP.
        /// </summary>
        public const string J_PTCP = "J$PTCP";

        /// <summary>
        /// J$WAPA.
        /// </summary>
        public const string J_WAPA = "J$WAPA";

        /// <summary>
        /// J$WAFN.
        /// </summary>
        public const string J_WAFN = "J$WAFN";

        /// <summary>
        /// J$WACN.
        /// </summary>
        public const string J_WACN = "J$WACN";

        /// <summary>
        /// J$WACD.
        /// </summary>
        public const string J_WACD = "J$WACD";

        /// <summary>
        /// J$WAAM.
        /// </summary>
        public const string J_WAAM = "J$WAAM";

        /// <summary>
        /// J$WASA.
        /// </summary>
        public const string J_WASA = "J$WASA";

        /// <summary>
        /// J$WASF.
        /// </summary>
        public const string J_WASF = "J$WASF";

        /// <summary>
        /// J$PFRQ.
        /// </summary>
        public const string J_PFRQ = "J$PFRQ";

        /// <summary>
        /// J$DGRP.
        /// </summary>
        public const string J_DGRP = "J$DGRP";

        /// <summary>
        /// J$WACM.
        /// </summary>
        public const string J_WACM = "J$WACM";

        /// <summary>
        /// J$WAEX.
        /// </summary>
        public const string J_WAEX = "J$WAEX";

        /// <summary>
        /// J$WAMW.
        /// </summary>
        public const string J_WAMW = "J$WAMW";

        /// <summary>
        /// J$WAPF.
        /// </summary>
        public const string J_WAPF = "J$WAPF";

        /// <summary>
        /// J$ANN8.
        /// </summary>
        public const string J_ANN8 = "J$ANN8";

        /// <summary>
        /// J$PAN8.
        /// </summary>
        public const string J_PAN8 = "J$PAN8";

        /// <summary>
        /// J$AD.
        /// </summary>
        public const string J_AD = "J$AD";

        /// <summary>
        /// J$NP.
        /// </summary>
        public const string J_NP = "J$NP";

        /// <summary>
        /// J$WAMS.
        /// </summary>
        public const string J_WAMS = "J$WAMS";

        /// <summary>
        /// J$WADF.
        /// </summary>
        public const string J_WADF = "J$WADF";

        /// <summary>
        /// J$WADR.
        /// </summary>
        public const string J_WADR = "J$WADR";

        /// <summary>
        /// J$ARRA.
        /// </summary>
        public const string J_ARRA = "J$ARRA";

        /// <summary>
        /// J$BAD.
        /// </summary>
        public const string J_BAD = "J$BAD";

        /// <summary>
        /// J$WAMA.
        /// </summary>
        public const string J_WAMA = "J$WAMA";

        /// <summary>
        /// J$WAFD.
        /// </summary>
        public const string J_WAFD = "J$WAFD";

        /// <summary>
        /// J$WATD.
        /// </summary>
        public const string J_WATD = "J$WATD";

        /// <summary>
        /// J$WADM.
        /// </summary>
        public const string J_WADM = "J$WADM";

        /// <summary>
        /// J$WAIA.
        /// </summary>
        public const string J_WAIA = "J$WAIA";

        /// <summary>
        /// J$WAIN.
        /// </summary>
        public const string J_WAIN = "J$WAIN";

        /// <summary>
        /// J$WALF.
        /// </summary>
        public const string J_WALF = "J$WALF";

        /// <summary>
        /// J$WAEF.
        /// </summary>
        public const string J_WAEF = "J$WAEF";

        /// <summary>
        /// J$WAAF.
        /// </summary>
        public const string J_WAAF = "J$WAAF";

        /// <summary>
        /// J$WAMF.
        /// </summary>
        public const string J_WAMF = "J$WAMF";

        /// <summary>
        /// J$WAOC.
        /// </summary>
        public const string J_WAOC = "J$WAOC";

        /// <summary>
        /// J$WACF.
        /// </summary>
        public const string J_WACF = "J$WACF";

        /// <summary>
        /// J$WAPI.
        /// </summary>
        public const string J_WAPI = "J$WAPI";

        /// <summary>
        /// J$WAWA.
        /// </summary>
        public const string J_WAWA = "J$WAWA";

        /// <summary>
        /// J$WAAO.
        /// </summary>
        public const string J_WAAO = "J$WAAO";
    }

    /// <inheritdoc />
    public override string TableName => "F06107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J$AN8", "J$AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J$PDBA", "J$PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J$WANO", "J$WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("J$WAP1", "J$WAP1", JdeDataType.Numeric),
        new JdeField("J$WAP2", "J$WAP2", JdeDataType.Numeric),
        new JdeField("J$WAFC", "J$WAFC", JdeDataType.String, 2),
        new JdeField("J$WAAL", "J$WAAL", JdeDataType.Numeric),
        new JdeField("J$WAAP", "J$WAAP", JdeDataType.Numeric),
        new JdeField("J$OAN8", "J$OAN8", JdeDataType.Numeric),
        new JdeField("J$WAAA", "J$WAAA", JdeDataType.Numeric),
        new JdeField("J$TARA", "J$TARA", JdeDataType.String, 20),
        new JdeField("J$PTCP", "J$PTCP", JdeDataType.String, 4),
        new JdeField("J$WAPA", "J$WAPA", JdeDataType.Numeric),
        new JdeField("J$WAFN", "J$WAFN", JdeDataType.String, 60),
        new JdeField("J$WACN", "J$WACN", JdeDataType.String, 60),
        new JdeField("J$WACD", "J$WACD", JdeDataType.Numeric),
        new JdeField("J$WAAM", "J$WAAM", JdeDataType.Numeric),
        new JdeField("J$WASA", "J$WASA", JdeDataType.Numeric),
        new JdeField("J$WASF", "J$WASF", JdeDataType.String, 2),
        new JdeField("J$PFRQ", "J$PFRQ", JdeDataType.String, 2),
        new JdeField("J$DGRP", "J$DGRP", JdeDataType.String, 4),
        new JdeField("J$WACM", "J$WACM", JdeDataType.String, 2),
        new JdeField("J$WAEX", "J$WAEX", JdeDataType.Numeric),
        new JdeField("J$WAMW", "J$WAMW", JdeDataType.Numeric),
        new JdeField("J$WAPF", "J$WAPF", JdeDataType.String, 2),
        new JdeField("J$ANN8", "J$ANN8", JdeDataType.Numeric),
        new JdeField("J$PAN8", "J$PAN8", JdeDataType.Numeric),
        new JdeField("J$AD", "J$AD", JdeDataType.Numeric),
        new JdeField("J$NP", "J$NP", JdeDataType.Numeric),
        new JdeField("J$WAMS", "J$WAMS", JdeDataType.String, 2),
        new JdeField("J$WADF", "J$WADF", JdeDataType.String, 2),
        new JdeField("J$WADR", "J$WADR", JdeDataType.Numeric),
        new JdeField("J$ARRA", "J$ARRA", JdeDataType.Numeric),
        new JdeField("J$BAD", "J$BAD", JdeDataType.Numeric),
        new JdeField("J$WAMA", "J$WAMA", JdeDataType.Numeric),
        new JdeField("J$WAFD", "J$WAFD", JdeDataType.Numeric),
        new JdeField("J$WATD", "J$WATD", JdeDataType.Numeric),
        new JdeField("J$WADM", "J$WADM", JdeDataType.String, 2),
        new JdeField("J$WAIA", "J$WAIA", JdeDataType.Numeric),
        new JdeField("J$WAIN", "J$WAIN", JdeDataType.Numeric),
        new JdeField("J$WALF", "J$WALF", JdeDataType.Numeric),
        new JdeField("J$WAEF", "J$WAEF", JdeDataType.Numeric),
        new JdeField("J$WAAF", "J$WAAF", JdeDataType.Numeric),
        new JdeField("J$WAMF", "J$WAMF", JdeDataType.Numeric),
        new JdeField("J$WAOC", "J$WAOC", JdeDataType.Numeric),
        new JdeField("J$WACF", "J$WACF", JdeDataType.Numeric),
        new JdeField("J$WAPI", "J$WAPI", JdeDataType.Numeric),
        new JdeField("J$WAWA", "J$WAWA", JdeDataType.Numeric),
        new JdeField("J$WAAO", "J$WAAO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06107_0", "Primary Key on J$AN8, J$PDBA, J$WANO", new[] { "J$AN8", "J$PDBA", "J$WANO" }, isUnique: true, isPrimaryKey: true)
    };
}
