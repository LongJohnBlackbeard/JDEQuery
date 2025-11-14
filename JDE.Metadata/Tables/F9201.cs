using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9201 - .
/// </summary>
public class F9201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRDTAI.
        /// </summary>
        public const string FRDTAI = "FRDTAI";

        /// <summary>
        /// FRCLAS.
        /// </summary>
        public const string FRCLAS = "FRCLAS";

        /// <summary>
        /// FRDTAT.
        /// </summary>
        public const string FRDTAT = "FRDTAT";

        /// <summary>
        /// FRDTAS.
        /// </summary>
        public const string FRDTAS = "FRDTAS";

        /// <summary>
        /// FRDTAD.
        /// </summary>
        public const string FRDTAD = "FRDTAD";

        /// <summary>
        /// FRPDTA.
        /// </summary>
        public const string FRPDTA = "FRPDTA";

        /// <summary>
        /// FRARRN.
        /// </summary>
        public const string FRARRN = "FRARRN";

        /// <summary>
        /// FRDVAL.
        /// </summary>
        public const string FRDVAL = "FRDVAL";

        /// <summary>
        /// FRLR.
        /// </summary>
        public const string FRLR = "FRLR";

        /// <summary>
        /// FRCDEC.
        /// </summary>
        public const string FRCDEC = "FRCDEC";

        /// <summary>
        /// FRDRUL.
        /// </summary>
        public const string FRDRUL = "FRDRUL";

        /// <summary>
        /// FRDRO1.
        /// </summary>
        public const string FRDRO1 = "FRDRO1";

        /// <summary>
        /// FRERUL.
        /// </summary>
        public const string FRERUL = "FRERUL";

        /// <summary>
        /// FRERO1.
        /// </summary>
        public const string FRERO1 = "FRERO1";

        /// <summary>
        /// FRERO2.
        /// </summary>
        public const string FRERO2 = "FRERO2";

        /// <summary>
        /// FRHLP1.
        /// </summary>
        public const string FRHLP1 = "FRHLP1";

        /// <summary>
        /// FRHLP2.
        /// </summary>
        public const string FRHLP2 = "FRHLP2";

        /// <summary>
        /// FRNNIX.
        /// </summary>
        public const string FRNNIX = "FRNNIX";

        /// <summary>
        /// FRNSY.
        /// </summary>
        public const string FRNSY = "FRNSY";

        /// <summary>
        /// FRRLS.
        /// </summary>
        public const string FRRLS = "FRRLS";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRUPMJ.
        /// </summary>
        public const string FRUPMJ = "FRUPMJ";

        /// <summary>
        /// FRPID.
        /// </summary>
        public const string FRPID = "FRPID";

        /// <summary>
        /// FRJOBN.
        /// </summary>
        public const string FRJOBN = "FRJOBN";

        /// <summary>
        /// FRUPMT.
        /// </summary>
        public const string FRUPMT = "FRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F9201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRDTAI", "FRDTAI", JdeDataType.String, 20, true, true),
        new JdeField("FRCLAS", "FRCLAS", JdeDataType.String, 20),
        new JdeField("FRDTAT", "FRDTAT", JdeDataType.String, 2),
        new JdeField("FRDTAS", "FRDTAS", JdeDataType.Numeric),
        new JdeField("FRDTAD", "FRDTAD", JdeDataType.Numeric),
        new JdeField("FRPDTA", "FRPDTA", JdeDataType.String, 20),
        new JdeField("FRARRN", "FRARRN", JdeDataType.Numeric),
        new JdeField("FRDVAL", "FRDVAL", JdeDataType.String, 80),
        new JdeField("FRLR", "FRLR", JdeDataType.String, 2),
        new JdeField("FRCDEC", "FRCDEC", JdeDataType.String, 2),
        new JdeField("FRDRUL", "FRDRUL", JdeDataType.String, 12),
        new JdeField("FRDRO1", "FRDRO1", JdeDataType.String, 80),
        new JdeField("FRERUL", "FRERUL", JdeDataType.String, 12),
        new JdeField("FRERO1", "FRERO1", JdeDataType.String, 80),
        new JdeField("FRERO2", "FRERO2", JdeDataType.String, 80),
        new JdeField("FRHLP1", "FRHLP1", JdeDataType.String, 20),
        new JdeField("FRHLP2", "FRHLP2", JdeDataType.String, 20),
        new JdeField("FRNNIX", "FRNNIX", JdeDataType.Numeric),
        new JdeField("FRNSY", "FRNSY", JdeDataType.String, 8),
        new JdeField("FRRLS", "FRRLS", JdeDataType.String, 20),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRUPMJ", "FRUPMJ", JdeDataType.Numeric),
        new JdeField("FRPID", "FRPID", JdeDataType.String, 20),
        new JdeField("FRJOBN", "FRJOBN", JdeDataType.String, 20),
        new JdeField("FRUPMT", "FRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9201_0", "Primary Key on FRDTAI", new[] { "FRDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
