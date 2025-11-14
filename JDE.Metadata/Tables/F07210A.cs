using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07210A - .
/// </summary>
public class F07210A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDPAYD.
        /// </summary>
        public const string YDPAYD = "YDPAYD";

        /// <summary>
        /// YDPTPF.
        /// </summary>
        public const string YDPTPF = "YDPTPF";

        /// <summary>
        /// YDPTCJF.
        /// </summary>
        public const string YDPTCJF = "YDPTCJF";

        /// <summary>
        /// YDSCBU.
        /// </summary>
        public const string YDSCBU = "YDSCBU";

        /// <summary>
        /// YDCBUCCA.
        /// </summary>
        public const string YDCBUCCA = "YDCBUCCA";

        /// <summary>
        /// YDCBUCCV.
        /// </summary>
        public const string YDCBUCCV = "YDCBUCCV";

        /// <summary>
        /// YDPTDL.
        /// </summary>
        public const string YDPTDL = "YDPTDL";

        /// <summary>
        /// YDPTASD.
        /// </summary>
        public const string YDPTASD = "YDPTASD";

        /// <summary>
        /// YDSPASUSU1.
        /// </summary>
        public const string YDSPASUSU1 = "YDSPASUSU1";

        /// <summary>
        /// YDSPASUSU2.
        /// </summary>
        public const string YDSPASUSU2 = "YDSPASUSU2";

        /// <summary>
        /// YDSPASUSU3.
        /// </summary>
        public const string YDSPASUSU3 = "YDSPASUSU3";

        /// <summary>
        /// YDSPASUSU4.
        /// </summary>
        public const string YDSPASUSU4 = "YDSPASUSU4";

        /// <summary>
        /// YDSPACUSU1.
        /// </summary>
        public const string YDSPACUSU1 = "YDSPACUSU1";

        /// <summary>
        /// YDSPACUSU2.
        /// </summary>
        public const string YDSPACUSU2 = "YDSPACUSU2";

        /// <summary>
        /// YDSPACUSU3.
        /// </summary>
        public const string YDSPACUSU3 = "YDSPACUSU3";

        /// <summary>
        /// YDSPACUSU4.
        /// </summary>
        public const string YDSPACUSU4 = "YDSPACUSU4";

        /// <summary>
        /// YDSPANUSU1.
        /// </summary>
        public const string YDSPANUSU1 = "YDSPANUSU1";

        /// <summary>
        /// YDSPANUSU2.
        /// </summary>
        public const string YDSPANUSU2 = "YDSPANUSU2";

        /// <summary>
        /// YDSPANUSU3.
        /// </summary>
        public const string YDSPANUSU3 = "YDSPANUSU3";

        /// <summary>
        /// YDSPANUSU4.
        /// </summary>
        public const string YDSPANUSU4 = "YDSPANUSU4";

        /// <summary>
        /// YDSPADUSU1.
        /// </summary>
        public const string YDSPADUSU1 = "YDSPADUSU1";

        /// <summary>
        /// YDSPADUSU2.
        /// </summary>
        public const string YDSPADUSU2 = "YDSPADUSU2";

        /// <summary>
        /// YDSPADUSU3.
        /// </summary>
        public const string YDSPADUSU3 = "YDSPADUSU3";

        /// <summary>
        /// YDSPADUSU4.
        /// </summary>
        public const string YDSPADUSU4 = "YDSPADUSU4";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07210A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDPAYD", "YDPAYD", JdeDataType.String, 20, true, true),
        new JdeField("YDPTPF", "YDPTPF", JdeDataType.String, 2),
        new JdeField("YDPTCJF", "YDPTCJF", JdeDataType.String, 2),
        new JdeField("YDSCBU", "YDSCBU", JdeDataType.String, 2),
        new JdeField("YDCBUCCA", "YDCBUCCA", JdeDataType.String, 20),
        new JdeField("YDCBUCCV", "YDCBUCCV", JdeDataType.String, 60),
        new JdeField("YDPTDL", "YDPTDL", JdeDataType.String, 2),
        new JdeField("YDPTASD", "YDPTASD", JdeDataType.String, 2),
        new JdeField("YDSPASUSU1", "YDSPASUSU1", JdeDataType.String, 60),
        new JdeField("YDSPASUSU2", "YDSPASUSU2", JdeDataType.String, 60),
        new JdeField("YDSPASUSU3", "YDSPASUSU3", JdeDataType.String, 60),
        new JdeField("YDSPASUSU4", "YDSPASUSU4", JdeDataType.String, 60),
        new JdeField("YDSPACUSU1", "YDSPACUSU1", JdeDataType.String, 2),
        new JdeField("YDSPACUSU2", "YDSPACUSU2", JdeDataType.String, 2),
        new JdeField("YDSPACUSU3", "YDSPACUSU3", JdeDataType.String, 2),
        new JdeField("YDSPACUSU4", "YDSPACUSU4", JdeDataType.String, 2),
        new JdeField("YDSPANUSU1", "YDSPANUSU1", JdeDataType.Numeric),
        new JdeField("YDSPANUSU2", "YDSPANUSU2", JdeDataType.Numeric),
        new JdeField("YDSPANUSU3", "YDSPANUSU3", JdeDataType.Numeric),
        new JdeField("YDSPANUSU4", "YDSPANUSU4", JdeDataType.Numeric),
        new JdeField("YDSPADUSU1", "YDSPADUSU1", JdeDataType.Numeric),
        new JdeField("YDSPADUSU2", "YDSPADUSU2", JdeDataType.Numeric),
        new JdeField("YDSPADUSU3", "YDSPADUSU3", JdeDataType.Numeric),
        new JdeField("YDSPADUSU4", "YDSPADUSU4", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07210A_0", "Primary Key on YDPAYD", new[] { "YDPAYD" }, isUnique: true, isPrimaryKey: true)
    };
}
