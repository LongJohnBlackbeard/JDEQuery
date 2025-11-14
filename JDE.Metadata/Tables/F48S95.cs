using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S95 - .
/// </summary>
public class F48S95 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WVANUM.
        /// </summary>
        public const string WVANUM = "WVANUM";

        /// <summary>
        /// WVTYKY.
        /// </summary>
        public const string WVTYKY = "WVTYKY";

        /// <summary>
        /// WVTKEY.
        /// </summary>
        public const string WVTKEY = "WVTKEY";

        /// <summary>
        /// WVEFTB.
        /// </summary>
        public const string WVEFTB = "WVEFTB";

        /// <summary>
        /// WVEFTE.
        /// </summary>
        public const string WVEFTE = "WVEFTE";

        /// <summary>
        /// WVOBJ.
        /// </summary>
        public const string WVOBJ = "WVOBJ";

        /// <summary>
        /// WVOBJT.
        /// </summary>
        public const string WVOBJT = "WVOBJT";

        /// <summary>
        /// WVSUB.
        /// </summary>
        public const string WVSUB = "WVSUB";

        /// <summary>
        /// WVSUBT.
        /// </summary>
        public const string WVSUBT = "WVSUBT";

        /// <summary>
        /// WVSBL.
        /// </summary>
        public const string WVSBL = "WVSBL";

        /// <summary>
        /// WVSBTC.
        /// </summary>
        public const string WVSBTC = "WVSBTC";

        /// <summary>
        /// WVGLC.
        /// </summary>
        public const string WVGLC = "WVGLC";

        /// <summary>
        /// WVCCOD.
        /// </summary>
        public const string WVCCOD = "WVCCOD";

        /// <summary>
        /// WVCNDC.
        /// </summary>
        public const string WVCNDC = "WVCNDC";

        /// <summary>
        /// WVMCUN.
        /// </summary>
        public const string WVMCUN = "WVMCUN";

        /// <summary>
        /// WVOBJN.
        /// </summary>
        public const string WVOBJN = "WVOBJN";

        /// <summary>
        /// WVSUBN.
        /// </summary>
        public const string WVSUBN = "WVSUBN";

        /// <summary>
        /// WVSBLN.
        /// </summary>
        public const string WVSBLN = "WVSBLN";

        /// <summary>
        /// WVSBLT.
        /// </summary>
        public const string WVSBLT = "WVSBLT";

        /// <summary>
        /// WVDL01.
        /// </summary>
        public const string WVDL01 = "WVDL01";

        /// <summary>
        /// WVLT.
        /// </summary>
        public const string WVLT = "WVLT";

        /// <summary>
        /// WVPCTI.
        /// </summary>
        public const string WVPCTI = "WVPCTI";

        /// <summary>
        /// WVEQCF.
        /// </summary>
        public const string WVEQCF = "WVEQCF";

        /// <summary>
        /// WVUNCF.
        /// </summary>
        public const string WVUNCF = "WVUNCF";

        /// <summary>
        /// WVEMPF.
        /// </summary>
        public const string WVEMPF = "WVEMPF";

        /// <summary>
        /// WVCRDB.
        /// </summary>
        public const string WVCRDB = "WVCRDB";

        /// <summary>
        /// WVUKID.
        /// </summary>
        public const string WVUKID = "WVUKID";

        /// <summary>
        /// WVPUKID.
        /// </summary>
        public const string WVPUKID = "WVPUKID";

        /// <summary>
        /// WVUSER.
        /// </summary>
        public const string WVUSER = "WVUSER";

        /// <summary>
        /// WVPID.
        /// </summary>
        public const string WVPID = "WVPID";

        /// <summary>
        /// WVJOBN.
        /// </summary>
        public const string WVJOBN = "WVJOBN";

        /// <summary>
        /// WVUPMT.
        /// </summary>
        public const string WVUPMT = "WVUPMT";

        /// <summary>
        /// WVUPMJ.
        /// </summary>
        public const string WVUPMJ = "WVUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F48S95";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WVANUM", "WVANUM", JdeDataType.Numeric),
        new JdeField("WVTYKY", "WVTYKY", JdeDataType.String, 2),
        new JdeField("WVTKEY", "WVTKEY", JdeDataType.String, 24),
        new JdeField("WVEFTB", "WVEFTB", JdeDataType.Numeric),
        new JdeField("WVEFTE", "WVEFTE", JdeDataType.Numeric),
        new JdeField("WVOBJ", "WVOBJ", JdeDataType.String, 12),
        new JdeField("WVOBJT", "WVOBJT", JdeDataType.String, 12),
        new JdeField("WVSUB", "WVSUB", JdeDataType.String, 16),
        new JdeField("WVSUBT", "WVSUBT", JdeDataType.String, 16),
        new JdeField("WVSBL", "WVSBL", JdeDataType.String, 16),
        new JdeField("WVSBTC", "WVSBTC", JdeDataType.String, 2),
        new JdeField("WVGLC", "WVGLC", JdeDataType.String, 8),
        new JdeField("WVCCOD", "WVCCOD", JdeDataType.String, 10),
        new JdeField("WVCNDC", "WVCNDC", JdeDataType.String, 20),
        new JdeField("WVMCUN", "WVMCUN", JdeDataType.String, 24),
        new JdeField("WVOBJN", "WVOBJN", JdeDataType.String, 12),
        new JdeField("WVSUBN", "WVSUBN", JdeDataType.String, 16),
        new JdeField("WVSBLN", "WVSBLN", JdeDataType.String, 16),
        new JdeField("WVSBLT", "WVSBLT", JdeDataType.String, 2),
        new JdeField("WVDL01", "WVDL01", JdeDataType.String, 60),
        new JdeField("WVLT", "WVLT", JdeDataType.String, 4),
        new JdeField("WVPCTI", "WVPCTI", JdeDataType.Numeric),
        new JdeField("WVEQCF", "WVEQCF", JdeDataType.String, 2),
        new JdeField("WVUNCF", "WVUNCF", JdeDataType.String, 2),
        new JdeField("WVEMPF", "WVEMPF", JdeDataType.String, 2),
        new JdeField("WVCRDB", "WVCRDB", JdeDataType.String, 2),
        new JdeField("WVUKID", "WVUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WVPUKID", "WVPUKID", JdeDataType.Numeric),
        new JdeField("WVUSER", "WVUSER", JdeDataType.String, 20),
        new JdeField("WVPID", "WVPID", JdeDataType.String, 20),
        new JdeField("WVJOBN", "WVJOBN", JdeDataType.String, 20),
        new JdeField("WVUPMT", "WVUPMT", JdeDataType.Numeric),
        new JdeField("WVUPMJ", "WVUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S95_0", "Primary Key on WVUKID", new[] { "WVUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S95_2", "Index on WVANUM, WVTYKY, WVTKEY, WVEFTB, WVEFTE", new[] { "WVANUM", "WVTYKY", "WVTKEY", "WVEFTB", "WVEFTE" }),
        new JdeIndex("F48S95_3", "Index on WVANUM, WVTYKY, WVTKEY, WVEFTB, WVOBJ, WVSUB, WVSBL, WVSBTC, WVGLC, WVCCOD", new[] { "WVANUM", "WVTYKY", "WVTKEY", "WVEFTB", "WVOBJ", "WVSUB", "WVSBL", "WVSBTC", "WVGLC", "WVCCOD" }),
        new JdeIndex("F48S95_4", "Index on WVPUKID, WVCNDC, WVLT", new[] { "WVPUKID", "WVCNDC", "WVLT" }),
        new JdeIndex("F48S95_5", "Index on WVPUKID, WVANUM, WVCCOD, WVGLC, WVSBL, WVTYKY, WVTKEY, WVEFTB, WVOBJ, WVSUB", new[] { "WVPUKID", "WVANUM", "WVCCOD", "WVGLC", "WVSBL", "WVTYKY", "WVTKEY", "WVEFTB", "WVOBJ", "WVSUB" }),
        new JdeIndex("F48S95_6", "Index on WVPUKID", new[] { "WVPUKID" })
    };
}
