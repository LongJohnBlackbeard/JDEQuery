using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00165 - .
/// </summary>
public class F00165 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDOBNM.
        /// </summary>
        public const string GDOBNM = "GDOBNM";

        /// <summary>
        /// GDTXKY.
        /// </summary>
        public const string GDTXKY = "GDTXKY";

        /// <summary>
        /// GDMOSEQN.
        /// </summary>
        public const string GDMOSEQN = "GDMOSEQN";

        /// <summary>
        /// GDGTMOTYPE.
        /// </summary>
        public const string GDGTMOTYPE = "GDGTMOTYPE";

        /// <summary>
        /// GDLNGP.
        /// </summary>
        public const string GDLNGP = "GDLNGP";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDTDAY.
        /// </summary>
        public const string GDTDAY = "GDTDAY";

        /// <summary>
        /// GDGTITNM.
        /// </summary>
        public const string GDGTITNM = "GDGTITNM";

        /// <summary>
        /// GDQUNAM.
        /// </summary>
        public const string GDQUNAM = "GDQUNAM";

        /// <summary>
        /// GDGTFILENM.
        /// </summary>
        public const string GDGTFILENM = "GDGTFILENM";

        /// <summary>
        /// GDGTFUTS1.
        /// </summary>
        public const string GDGTFUTS1 = "GDGTFUTS1";

        /// <summary>
        /// GDGTFUTS2.
        /// </summary>
        public const string GDGTFUTS2 = "GDGTFUTS2";

        /// <summary>
        /// GDGTFUTS3.
        /// </summary>
        public const string GDGTFUTS3 = "GDGTFUTS3";

        /// <summary>
        /// GDGTFUTS4.
        /// </summary>
        public const string GDGTFUTS4 = "GDGTFUTS4";

        /// <summary>
        /// GDGTFUTM1.
        /// </summary>
        public const string GDGTFUTM1 = "GDGTFUTM1";

        /// <summary>
        /// GDGTFUTM2.
        /// </summary>
        public const string GDGTFUTM2 = "GDGTFUTM2";

        /// <summary>
        /// GDTXFT.
        /// </summary>
        public const string GDTXFT = "GDTXFT";
    }

    /// <inheritdoc />
    public override string TableName => "F00165";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDOBNM", "GDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("GDTXKY", "GDTXKY", JdeDataType.String, 508, true, true),
        new JdeField("GDMOSEQN", "GDMOSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("GDGTMOTYPE", "GDGTMOTYPE", JdeDataType.Numeric),
        new JdeField("GDLNGP", "GDLNGP", JdeDataType.String, 4),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric),
        new JdeField("GDTDAY", "GDTDAY", JdeDataType.Numeric),
        new JdeField("GDGTITNM", "GDGTITNM", JdeDataType.String, 100),
        new JdeField("GDQUNAM", "GDQUNAM", JdeDataType.String, 60),
        new JdeField("GDGTFILENM", "GDGTFILENM", JdeDataType.String, 508),
        new JdeField("GDGTFUTS1", "GDGTFUTS1", JdeDataType.String, 20),
        new JdeField("GDGTFUTS2", "GDGTFUTS2", JdeDataType.String, 20),
        new JdeField("GDGTFUTS3", "GDGTFUTS3", JdeDataType.String, 100),
        new JdeField("GDGTFUTS4", "GDGTFUTS4", JdeDataType.String, 100),
        new JdeField("GDGTFUTM1", "GDGTFUTM1", JdeDataType.Numeric),
        new JdeField("GDGTFUTM2", "GDGTFUTM2", JdeDataType.Numeric),
        new JdeField("GDTXFT", "GDTXFT", JdeDataType.String)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00165_0", "Primary Key on GDOBNM, GDTXKY, GDMOSEQN", new[] { "GDOBNM", "GDTXKY", "GDMOSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00165_2", "Index on GDOBNM, GDTXKY, GDGTMOTYPE, GDMOSEQN", new[] { "GDOBNM", "GDTXKY", "GDGTMOTYPE", "GDMOSEQN" }),
        new JdeIndex("F00165_3", "Index on GDOBNM, GDTXKY", new[] { "GDOBNM", "GDTXKY" }),
        new JdeIndex("F00165_4", "Index on GDLNGP, GDOBNM, GDTXKY, GDGTMOTYPE, GDMOSEQN", new[] { "GDLNGP", "GDOBNM", "GDTXKY", "GDGTMOTYPE", "GDMOSEQN" }),
        new JdeIndex("F00165_5", "Index on GDQUNAM, GDGTFILENM", new[] { "GDQUNAM", "GDGTFILENM" })
    };
}
