using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS20 - .
/// </summary>
public class F54HS20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHHSIHG.
        /// </summary>
        public const string SHHSIHG = "SHHSIHG";

        /// <summary>
        /// SHESTB.
        /// </summary>
        public const string SHESTB = "SHESTB";

        /// <summary>
        /// SHCO.
        /// </summary>
        public const string SHCO = "SHCO";

        /// <summary>
        /// SHMCUS.
        /// </summary>
        public const string SHMCUS = "SHMCUS";

        /// <summary>
        /// SHMCU.
        /// </summary>
        public const string SHMCU = "SHMCU";

        /// <summary>
        /// SHHSICRN.
        /// </summary>
        public const string SHHSICRN = "SHHSICRN";

        /// <summary>
        /// SHHSIYR.
        /// </summary>
        public const string SHHSIYR = "SHHSIYR";

        /// <summary>
        /// SHHSIMB.
        /// </summary>
        public const string SHHSIMB = "SHHSIMB";

        /// <summary>
        /// SHHSIH01.
        /// </summary>
        public const string SHHSIH01 = "SHHSIH01";

        /// <summary>
        /// SHHSIH02.
        /// </summary>
        public const string SHHSIH02 = "SHHSIH02";

        /// <summary>
        /// SHHSIH03.
        /// </summary>
        public const string SHHSIH03 = "SHHSIH03";

        /// <summary>
        /// SHHSIH04.
        /// </summary>
        public const string SHHSIH04 = "SHHSIH04";

        /// <summary>
        /// SHHSIH05.
        /// </summary>
        public const string SHHSIH05 = "SHHSIH05";

        /// <summary>
        /// SHHSIH06.
        /// </summary>
        public const string SHHSIH06 = "SHHSIH06";

        /// <summary>
        /// SHHSIH07.
        /// </summary>
        public const string SHHSIH07 = "SHHSIH07";

        /// <summary>
        /// SHHSIH08.
        /// </summary>
        public const string SHHSIH08 = "SHHSIH08";

        /// <summary>
        /// SHHSIH09.
        /// </summary>
        public const string SHHSIH09 = "SHHSIH09";

        /// <summary>
        /// SHHSIH10.
        /// </summary>
        public const string SHHSIH10 = "SHHSIH10";

        /// <summary>
        /// SHHSIH11.
        /// </summary>
        public const string SHHSIH11 = "SHHSIH11";

        /// <summary>
        /// SHHSIH12.
        /// </summary>
        public const string SHHSIH12 = "SHHSIH12";

        /// <summary>
        /// SHHSIHAT.
        /// </summary>
        public const string SHHSIHAT = "SHHSIHAT";

        /// <summary>
        /// SHHSIAV.
        /// </summary>
        public const string SHHSIAV = "SHHSIAV";

        /// <summary>
        /// SHURAB.
        /// </summary>
        public const string SHURAB = "SHURAB";

        /// <summary>
        /// SHURCD.
        /// </summary>
        public const string SHURCD = "SHURCD";

        /// <summary>
        /// SHURAT.
        /// </summary>
        public const string SHURAT = "SHURAT";

        /// <summary>
        /// SHURDT.
        /// </summary>
        public const string SHURDT = "SHURDT";

        /// <summary>
        /// SHURRF.
        /// </summary>
        public const string SHURRF = "SHURRF";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHHSIHG", "SHHSIHG", JdeDataType.String, 2, true, true),
        new JdeField("SHESTB", "SHESTB", JdeDataType.Numeric, null, true, true),
        new JdeField("SHCO", "SHCO", JdeDataType.String, 10, true, true),
        new JdeField("SHMCUS", "SHMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SHMCU", "SHMCU", JdeDataType.String, 24, true, true),
        new JdeField("SHHSICRN", "SHHSICRN", JdeDataType.Numeric, null, true, true),
        new JdeField("SHHSIYR", "SHHSIYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SHHSIMB", "SHHSIMB", JdeDataType.String, 4, true, true),
        new JdeField("SHHSIH01", "SHHSIH01", JdeDataType.Numeric),
        new JdeField("SHHSIH02", "SHHSIH02", JdeDataType.Numeric),
        new JdeField("SHHSIH03", "SHHSIH03", JdeDataType.Numeric),
        new JdeField("SHHSIH04", "SHHSIH04", JdeDataType.Numeric),
        new JdeField("SHHSIH05", "SHHSIH05", JdeDataType.Numeric),
        new JdeField("SHHSIH06", "SHHSIH06", JdeDataType.Numeric),
        new JdeField("SHHSIH07", "SHHSIH07", JdeDataType.Numeric),
        new JdeField("SHHSIH08", "SHHSIH08", JdeDataType.Numeric),
        new JdeField("SHHSIH09", "SHHSIH09", JdeDataType.Numeric),
        new JdeField("SHHSIH10", "SHHSIH10", JdeDataType.Numeric),
        new JdeField("SHHSIH11", "SHHSIH11", JdeDataType.Numeric),
        new JdeField("SHHSIH12", "SHHSIH12", JdeDataType.Numeric),
        new JdeField("SHHSIHAT", "SHHSIHAT", JdeDataType.Numeric),
        new JdeField("SHHSIAV", "SHHSIAV", JdeDataType.Numeric),
        new JdeField("SHURAB", "SHURAB", JdeDataType.Numeric),
        new JdeField("SHURCD", "SHURCD", JdeDataType.String, 4),
        new JdeField("SHURAT", "SHURAT", JdeDataType.Numeric),
        new JdeField("SHURDT", "SHURDT", JdeDataType.Numeric),
        new JdeField("SHURRF", "SHURRF", JdeDataType.String, 30),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS20_0", "Primary Key on SHHSIHG, SHHSIMB, SHESTB, SHCO, SHMCUS, SHMCU, SHHSICRN, SHHSIYR", new[] { "SHHSIHG", "SHHSIMB", "SHESTB", "SHCO", "SHMCUS", "SHMCU", "SHHSICRN", "SHHSIYR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54HS20_2", "Index on SHHSIHG, SHHSIMB, SHESTB, SHHSIYR", new[] { "SHHSIHG", "SHHSIMB", "SHESTB", "SHHSIYR" })
    };
}
