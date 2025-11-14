using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74101 - .
/// </summary>
public class F74101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VVAN8.
        /// </summary>
        public const string VVAN8 = "VVAN8";

        /// <summary>
        /// VVALPH.
        /// </summary>
        public const string VVALPH = "VVALPH";

        /// <summary>
        /// VVADD1.
        /// </summary>
        public const string VVADD1 = "VVADD1";

        /// <summary>
        /// VVADD2.
        /// </summary>
        public const string VVADD2 = "VVADD2";

        /// <summary>
        /// VVADD3.
        /// </summary>
        public const string VVADD3 = "VVADD3";

        /// <summary>
        /// VVADD4.
        /// </summary>
        public const string VVADD4 = "VVADD4";

        /// <summary>
        /// VV74VAT.
        /// </summary>
        public const string VV74VAT = "VV74VAT";

        /// <summary>
        /// VV74CTR.
        /// </summary>
        public const string VV74CTR = "VV74CTR";

        /// <summary>
        /// VV74CNO.
        /// </summary>
        public const string VV74CNO = "VV74CNO";

        /// <summary>
        /// VV74RVAT.
        /// </summary>
        public const string VV74RVAT = "VV74RVAT";

        /// <summary>
        /// VV74RCTR.
        /// </summary>
        public const string VV74RCTR = "VV74RCTR";

        /// <summary>
        /// VV74RSD.
        /// </summary>
        public const string VV74RSD = "VV74RSD";

        /// <summary>
        /// VVFFG1.
        /// </summary>
        public const string VVFFG1 = "VVFFG1";

        /// <summary>
        /// VVFFU4.
        /// </summary>
        public const string VVFFU4 = "VVFFU4";

        /// <summary>
        /// VVFUT3.
        /// </summary>
        public const string VVFUT3 = "VVFUT3";

        /// <summary>
        /// VVUSER.
        /// </summary>
        public const string VVUSER = "VVUSER";

        /// <summary>
        /// VVPID.
        /// </summary>
        public const string VVPID = "VVPID";

        /// <summary>
        /// VVJOBN.
        /// </summary>
        public const string VVJOBN = "VVJOBN";

        /// <summary>
        /// VVUPMJ.
        /// </summary>
        public const string VVUPMJ = "VVUPMJ";

        /// <summary>
        /// VVUPMT.
        /// </summary>
        public const string VVUPMT = "VVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VVAN8", "VVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VVALPH", "VVALPH", JdeDataType.String, 80),
        new JdeField("VVADD1", "VVADD1", JdeDataType.String, 80),
        new JdeField("VVADD2", "VVADD2", JdeDataType.String, 80),
        new JdeField("VVADD3", "VVADD3", JdeDataType.String, 80),
        new JdeField("VVADD4", "VVADD4", JdeDataType.String, 80),
        new JdeField("VV74VAT", "VV74VAT", JdeDataType.String, 40),
        new JdeField("VV74CTR", "VV74CTR", JdeDataType.String, 6),
        new JdeField("VV74CNO", "VV74CNO", JdeDataType.String, 80),
        new JdeField("VV74RVAT", "VV74RVAT", JdeDataType.String, 40),
        new JdeField("VV74RCTR", "VV74RCTR", JdeDataType.String, 6),
        new JdeField("VV74RSD", "VV74RSD", JdeDataType.Numeric),
        new JdeField("VVFFG1", "VVFFG1", JdeDataType.String, 2),
        new JdeField("VVFFU4", "VVFFU4", JdeDataType.Numeric),
        new JdeField("VVFUT3", "VVFUT3", JdeDataType.String, 60),
        new JdeField("VVUSER", "VVUSER", JdeDataType.String, 20),
        new JdeField("VVPID", "VVPID", JdeDataType.String, 20),
        new JdeField("VVJOBN", "VVJOBN", JdeDataType.String, 20),
        new JdeField("VVUPMJ", "VVUPMJ", JdeDataType.Numeric),
        new JdeField("VVUPMT", "VVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74101_0", "Primary Key on VVAN8", new[] { "VVAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
