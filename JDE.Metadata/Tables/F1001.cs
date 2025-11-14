using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1001 - .
/// </summary>
public class F1001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPEDBT.
        /// </summary>
        public const string GPEDBT = "GPEDBT";

        /// <summary>
        /// GPEDUS.
        /// </summary>
        public const string GPEDUS = "GPEDUS";

        /// <summary>
        /// GPEDTN.
        /// </summary>
        public const string GPEDTN = "GPEDTN";

        /// <summary>
        /// GPTRFG.
        /// </summary>
        public const string GPTRFG = "GPTRFG";

        /// <summary>
        /// GPTRSE.
        /// </summary>
        public const string GPTRSE = "GPTRSE";

        /// <summary>
        /// GPDTSE.
        /// </summary>
        public const string GPDTSE = "GPDTSE";

        /// <summary>
        /// GPTRRC.
        /// </summary>
        public const string GPTRRC = "GPTRRC";

        /// <summary>
        /// GPDTRI.
        /// </summary>
        public const string GPDTRI = "GPDTRI";

        /// <summary>
        /// GPCCSE.
        /// </summary>
        public const string GPCCSE = "GPCCSE";

        /// <summary>
        /// GPCNAM.
        /// </summary>
        public const string GPCNAM = "GPCNAM";

        /// <summary>
        /// GPPN.
        /// </summary>
        public const string GPPN = "GPPN";

        /// <summary>
        /// GPFY.
        /// </summary>
        public const string GPFY = "GPFY";

        /// <summary>
        /// GPCTRY.
        /// </summary>
        public const string GPCTRY = "GPCTRY";

        /// <summary>
        /// GPLT.
        /// </summary>
        public const string GPLT = "GPLT";

        /// <summary>
        /// GPCO.
        /// </summary>
        public const string GPCO = "GPCO";

        /// <summary>
        /// GPIN01.
        /// </summary>
        public const string GPIN01 = "GPIN01";

        /// <summary>
        /// GPIN02.
        /// </summary>
        public const string GPIN02 = "GPIN02";

        /// <summary>
        /// GPIN03.
        /// </summary>
        public const string GPIN03 = "GPIN03";

        /// <summary>
        /// GPIN04.
        /// </summary>
        public const string GPIN04 = "GPIN04";

        /// <summary>
        /// GPIN05.
        /// </summary>
        public const string GPIN05 = "GPIN05";

        /// <summary>
        /// GPIN06.
        /// </summary>
        public const string GPIN06 = "GPIN06";

        /// <summary>
        /// GPIN07.
        /// </summary>
        public const string GPIN07 = "GPIN07";

        /// <summary>
        /// GPIN08.
        /// </summary>
        public const string GPIN08 = "GPIN08";

        /// <summary>
        /// GPIN09.
        /// </summary>
        public const string GPIN09 = "GPIN09";

        /// <summary>
        /// GPIN10.
        /// </summary>
        public const string GPIN10 = "GPIN10";

        /// <summary>
        /// GPIN11.
        /// </summary>
        public const string GPIN11 = "GPIN11";

        /// <summary>
        /// GPIN12.
        /// </summary>
        public const string GPIN12 = "GPIN12";

        /// <summary>
        /// GPURDT.
        /// </summary>
        public const string GPURDT = "GPURDT";

        /// <summary>
        /// GPURRF.
        /// </summary>
        public const string GPURRF = "GPURRF";

        /// <summary>
        /// GPURCD.
        /// </summary>
        public const string GPURCD = "GPURCD";

        /// <summary>
        /// GPURC1.
        /// </summary>
        public const string GPURC1 = "GPURC1";

        /// <summary>
        /// GPURC2.
        /// </summary>
        public const string GPURC2 = "GPURC2";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPVERS.
        /// </summary>
        public const string GPVERS = "GPVERS";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPUPMT.
        /// </summary>
        public const string GPUPMT = "GPUPMT";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPEDBT", "GPEDBT", JdeDataType.String, 30, true, true),
        new JdeField("GPEDUS", "GPEDUS", JdeDataType.String, 20, true, true),
        new JdeField("GPEDTN", "GPEDTN", JdeDataType.String, 44, true, true),
        new JdeField("GPTRFG", "GPTRFG", JdeDataType.String, 2),
        new JdeField("GPTRSE", "GPTRSE", JdeDataType.Numeric),
        new JdeField("GPDTSE", "GPDTSE", JdeDataType.Numeric),
        new JdeField("GPTRRC", "GPTRRC", JdeDataType.Numeric),
        new JdeField("GPDTRI", "GPDTRI", JdeDataType.Numeric),
        new JdeField("GPCCSE", "GPCCSE", JdeDataType.String, 2),
        new JdeField("GPCNAM", "GPCNAM", JdeDataType.String, 6),
        new JdeField("GPPN", "GPPN", JdeDataType.Numeric),
        new JdeField("GPFY", "GPFY", JdeDataType.Numeric),
        new JdeField("GPCTRY", "GPCTRY", JdeDataType.Numeric),
        new JdeField("GPLT", "GPLT", JdeDataType.String, 4),
        new JdeField("GPCO", "GPCO", JdeDataType.String, 10),
        new JdeField("GPIN01", "GPIN01", JdeDataType.String, 2),
        new JdeField("GPIN02", "GPIN02", JdeDataType.String, 2),
        new JdeField("GPIN03", "GPIN03", JdeDataType.String, 2),
        new JdeField("GPIN04", "GPIN04", JdeDataType.String, 2),
        new JdeField("GPIN05", "GPIN05", JdeDataType.String, 2),
        new JdeField("GPIN06", "GPIN06", JdeDataType.String, 2),
        new JdeField("GPIN07", "GPIN07", JdeDataType.String, 2),
        new JdeField("GPIN08", "GPIN08", JdeDataType.String, 2),
        new JdeField("GPIN09", "GPIN09", JdeDataType.String, 2),
        new JdeField("GPIN10", "GPIN10", JdeDataType.String, 2),
        new JdeField("GPIN11", "GPIN11", JdeDataType.String, 2),
        new JdeField("GPIN12", "GPIN12", JdeDataType.String, 2),
        new JdeField("GPURDT", "GPURDT", JdeDataType.Numeric),
        new JdeField("GPURRF", "GPURRF", JdeDataType.String, 30),
        new JdeField("GPURCD", "GPURCD", JdeDataType.String, 4),
        new JdeField("GPURC1", "GPURC1", JdeDataType.String, 6),
        new JdeField("GPURC2", "GPURC2", JdeDataType.String, 20),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPVERS", "GPVERS", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1001_0", "Primary Key on GPEDBT, GPEDUS, GPEDTN", new[] { "GPEDBT", "GPEDUS", "GPEDTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1001_2", "Index on GPCNAM, GPEDUS, GPEDTN", new[] { "GPCNAM", "GPEDUS", "GPEDTN" }),
        new JdeIndex("F1001_3", "Index on GPCNAM, GPTRFG", new[] { "GPCNAM", "GPTRFG" }),
        new JdeIndex("F1001_4", "Index on GPEDTN, GPEDUS, GPTRFG, GPCNAM", new[] { "GPEDTN", "GPEDUS", "GPTRFG", "GPCNAM" }),
        new JdeIndex("F1001_5", "Index on GPEDUS, GPEDTN, GPUPMJ, GPUPMT", new[] { "GPEDUS", "GPEDTN", "GPUPMJ", "GPUPMT" })
    };
}
