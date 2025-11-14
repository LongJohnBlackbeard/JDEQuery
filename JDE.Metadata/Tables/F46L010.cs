using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L010 - .
/// </summary>
public class F46L010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSMCU.
        /// </summary>
        public const string LSMCU = "LSMCU";

        /// <summary>
        /// LSLPMN.
        /// </summary>
        public const string LSLPMN = "LSLPMN";

        /// <summary>
        /// LSEFTJ.
        /// </summary>
        public const string LSEFTJ = "LSEFTJ";

        /// <summary>
        /// LSLPSG.
        /// </summary>
        public const string LSLPSG = "LSLPSG";

        /// <summary>
        /// LSLPSTP.
        /// </summary>
        public const string LSLPSTP = "LSLPSTP";

        /// <summary>
        /// LSLPLG.
        /// </summary>
        public const string LSLPLG = "LSLPLG";

        /// <summary>
        /// LSLPHC.
        /// </summary>
        public const string LSLPHC = "LSLPHC";

        /// <summary>
        /// LSLPLT.
        /// </summary>
        public const string LSLPLT = "LSLPLT";

        /// <summary>
        /// LSSY.
        /// </summary>
        public const string LSSY = "LSSY";

        /// <summary>
        /// LSRT.
        /// </summary>
        public const string LSRT = "LSRT";

        /// <summary>
        /// LSCDBF.
        /// </summary>
        public const string LSCDBF = "LSCDBF";

        /// <summary>
        /// LSFNNM.
        /// </summary>
        public const string LSFNNM = "LSFNNM";

        /// <summary>
        /// LSURCD.
        /// </summary>
        public const string LSURCD = "LSURCD";

        /// <summary>
        /// LSURDT.
        /// </summary>
        public const string LSURDT = "LSURDT";

        /// <summary>
        /// LSURAT.
        /// </summary>
        public const string LSURAT = "LSURAT";

        /// <summary>
        /// LSURAB.
        /// </summary>
        public const string LSURAB = "LSURAB";

        /// <summary>
        /// LSURRF.
        /// </summary>
        public const string LSURRF = "LSURRF";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSMKEY.
        /// </summary>
        public const string LSMKEY = "LSMKEY";

        /// <summary>
        /// LSUPMJ.
        /// </summary>
        public const string LSUPMJ = "LSUPMJ";

        /// <summary>
        /// LSTDAY.
        /// </summary>
        public const string LSTDAY = "LSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSMCU", "LSMCU", JdeDataType.String, 24, true, true),
        new JdeField("LSLPMN", "LSLPMN", JdeDataType.String, 24, true, true),
        new JdeField("LSEFTJ", "LSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LSLPSG", "LSLPSG", JdeDataType.Numeric, null, true, true),
        new JdeField("LSLPSTP", "LSLPSTP", JdeDataType.Numeric),
        new JdeField("LSLPLG", "LSLPLG", JdeDataType.Numeric),
        new JdeField("LSLPHC", "LSLPHC", JdeDataType.String, 80),
        new JdeField("LSLPLT", "LSLPLT", JdeDataType.String, 2),
        new JdeField("LSSY", "LSSY", JdeDataType.String, 8),
        new JdeField("LSRT", "LSRT", JdeDataType.String, 4),
        new JdeField("LSCDBF", "LSCDBF", JdeDataType.String, 64),
        new JdeField("LSFNNM", "LSFNNM", JdeDataType.String, 64),
        new JdeField("LSURCD", "LSURCD", JdeDataType.String, 4),
        new JdeField("LSURDT", "LSURDT", JdeDataType.Numeric),
        new JdeField("LSURAT", "LSURAT", JdeDataType.Numeric),
        new JdeField("LSURAB", "LSURAB", JdeDataType.Numeric),
        new JdeField("LSURRF", "LSURRF", JdeDataType.String, 30),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSMKEY", "LSMKEY", JdeDataType.String, 30),
        new JdeField("LSUPMJ", "LSUPMJ", JdeDataType.Numeric),
        new JdeField("LSTDAY", "LSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L010_0", "Primary Key on LSMCU, LSLPMN, LSEFTJ, LSLPSG", new[] { "LSMCU", "LSLPMN", "LSEFTJ", "LSLPSG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L010_2", "Index on LSMCU, LSLPMN, LSEFTJ", new[] { "LSMCU", "LSLPMN", "LSEFTJ" })
    };
}
